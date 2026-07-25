using Quiz.Domain.Questions;

namespace Quiz.Infrastructure.Persistence.Configurations;

/// <summary>
/// Формирует компактный правильный вариант, не раскрывая его длиной среди отвлекающих ответов.
/// Полное объяснение по-прежнему хранится в IdealAnswer и показывается только после выбора.
/// </summary>
internal static class QuestionCorrectOptionCatalog
{
    private static readonly IReadOnlyDictionary<int, string> CSharpOverrides =
        new Dictionary<int, string>
        {
            [4] = "Span<T> — безаллокационный view непрерывной памяти с lifetime-ограничениями.",
            [5] = "CancellationToken передают по всей цепочке и проверяют в поддерживающих его API.",
            [6] = "GC поколений оптимизирует короткоживущие объекты, а крупные размещает в LOH.",
            [7] = "Долгое pinning запрещает GC перемещать объекты и фрагментирует управляемую кучу.",
            [8] = "ThreadPool starvation проявляется очередями работ и ростом latency при умеренном CPU.",
            [9] = "ValueTask оправдан в горячем API, которое часто завершается синхронно.",
            [10] = "out разрешает использовать IEnumerable<Dog> как IEnumerable<Animal>, а in — наоборот.",
            [12] = "Dispose освобождает только принадлежащие объекту ресурсы и должен быть идемпотентным.",
            [14] = "volatile обеспечивает видимость чтений и записей, но не атомарность составных операций.",
            [15] = "Неизменяемый снимок строят целиком и публикуют атомарной заменой ссылки.",
            [16] = "Reflection переносит ошибки в runtime и усложняет trimming, AOT и горячие пути.",
            [17] = "Tiered JIT ускоряет старт, а dynamic PGO специализирует горячий код по профилю.",
            [18] = "Долгоживущий publisher через delegate удерживает subscriber сильной ссылкой.",
            [19] = "Исключения дороги и не подходят для ожидаемого управления потоком выполнения.",
            [20] = "NRT — статический анализ nullability, а не runtime-гарантия отсутствия null.",
            [21] = "Захват локальных переменных в lambda обычно создаёт closure и дополнительную аллокацию.",
            [22] = "Deferred LINQ выполняется при перечислении и может повторить I/O или вычисления.",
            [23] = "Task.WhenAll ждёт все задачи; await обычно пробрасывает одну из накопленных ошибок.",
            [24] = "Bounded Channel ограничивает очередь и создаёт backpressure для быстрого producer.",
            [25] = "SafeHandle надёжно освобождает native handle даже при исключениях и финализации.",
            [26] = "Generic со значимым типом обычно избегает boxing благодаря специализации runtime.",
            [27] = "in и ref readonly уменьшают копирование крупных struct без права их изменения.",
            [28] = "Value object неизменяем, валиден с момента создания и сравнивается по значению.",
            [29] = "Sync-over-async создаёт deadlock в context или ThreadPool starvation на сервере.",
            [30] = "Retry применяют к транзиентным идемпотентным операциям с backoff, jitter и timeout.",
            [32] = "Random.Shared потокобезопасен и подходит для некриптографических случайных значений.",
            [35] = "False sharing создаёт coherence traffic между независимыми данными одной cache line.",
            [36] = "BackgroundService учитывает stoppingToken и при shutdown дренирует текущую работу.",
            [37] = "Fire-and-forget скрывает завершение и может пережить захваченный scope.",
            [38] = "GetOrAdd может вызвать factory параллельно несколько раз, поэтому side effects опасны.",
            [39] = "IAsyncEnumerable отдаёт элементы по готовности и создаёт backpressure через MoveNextAsync.",
            [40] = "Утечку ищут, разделяя managed heap, native memory, working set и кэши.",
            [41] = "Будет выведено 333: все лямбды захватывают одну переменную i, равную 3 к моменту вызова.",
            [42] = ".Result блокирует поток ThreadPool и под нагрузкой может вызвать starvation и резкий рост latency.",
            [43] = "Повторный await небезопасен: ValueTask может опираться на одноразовый IValueTaskSource.",
            [44] = "Код не компилируется; для асинхронной блокировки нужен SemaphoreSlim с WaitAsync и Release в finally.",
            [45] = "Нет: GetOrAdd атомарно выбирает значение, но его value factory может выполниться несколько раз.",
            [46] = "Метод не компилируется: ReadOnlySpan<byte> как ref struct нельзя переносить через async-границу.",
            [47] = "await обычно пробрасывает одну ошибку, а все причины нужно читать из Exception задачи Task.WhenAll.",
            [48] = "Вызывающий код не получает Task, поэтому не может ожидать Process и штатно обработать его исключение.",
            [49] = "Фоновая задача может обратиться к scope после его уничтожения и потерять собственное исключение.",
            [50] = "Publisher через delegate удерживает сильную ссылку на Subscriber, пока подписка не будет снята."
        };

    public static string Get(QuestionSeedData question)
    {
        if (question.Topic == Topic.CSharp &&
            CSharpOverrides.TryGetValue(question.Sequence, out var option))
        {
            return option;
        }

        return TakeFirstSentence(question.IdealAnswer);
    }

    private static string TakeFirstSentence(string explanation)
    {
        var sentenceEnd = explanation.IndexOf(". ", StringComparison.Ordinal);
        var sentence = sentenceEnd < 0
            ? explanation.Trim()
            : explanation[..(sentenceEnd + 1)].Trim();

        if (sentence.Length <= 105)
        {
            return sentence;
        }

        string[] clauseSeparators =
        [
            "; ",
            ", а ",
            ", но ",
            ", поэтому ",
            ", потому ",
            ", чтобы ",
            " и затем "
        ];

        var clauseEnd = clauseSeparators
            .Select(separator => sentence.IndexOf(
                separator,
                55,
                StringComparison.OrdinalIgnoreCase))
            .Where(index => index >= 55)
            .DefaultIfEmpty(-1)
            .Min();

        return clauseEnd > 0
            ? $"{sentence[..clauseEnd].TrimEnd(',', ';')}."
            : sentence;
    }
}
