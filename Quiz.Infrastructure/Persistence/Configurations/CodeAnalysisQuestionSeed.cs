using Quiz.Domain.Questions;

namespace Quiz.Infrastructure.Persistence.Configurations;

/// <summary>
/// Дополнительные C#-задачи на чтение и анализ кода.
/// </summary>
internal static class CodeAnalysisQuestionSeed
{
    public static readonly object[] All =
    [
        new
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000041"),
            Topic = Topic.CSharp,
            Difficulty = Difficulty.MiddlePlus,
            Text = """
                   Проанализируйте код:

                   var actions = new List<Action>();
                   for (var i = 0; i < 3; i++)
                       actions.Add(() => Console.Write(i));

                   foreach (var action in actions)
                       action();

                   Что будет выведено и почему?
                   """,
            IdealAnswer = "Будет выведено 333. Lambda захватывает одну переменную i, а не её значение на каждой итерации; к моменту вызова actions цикл завершён и i равна 3. Для фиксации значения внутри цикла создают локальную копию: var copy = i."
        },
        new
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000042"),
            Topic = Topic.CSharp,
            Difficulty = Difficulty.MiddlePlus,
            Text = """
                   Проанализируйте код ASP.NET Core:

                   public string Get()
                   {
                       return LoadAsync().Result;
                   }

                   Какой основной production-риск создаёт этот код?
                   """,
            IdealAnswer = "В ASP.NET Core обычно нет SynchronizationContext, поэтому классический UI-deadlock не гарантирован. Однако .Result блокирует worker ThreadPool; под нагрузкой это создаёт starvation и резкий рост latency. Цепочку следует сделать асинхронной и использовать await."
        },
        new
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000043"),
            Topic = Topic.CSharp,
            Difficulty = Difficulty.Senior,
            Text = """
                   Проанализируйте код:

                   ValueTask<int> operation = ReadAsync();
                   var first = await operation;
                   var second = await operation;

                   Почему такой код нельзя считать безопасным для любого ValueTask?
                   """,
            IdealAnswer = "ValueTask может быть backed обычным Task, но также одноразовым IValueTaskSource. Во втором случае повторный await нарушает контракт и может дать исключение или неопределённое поведение. ValueTask следует await-ить один раз либо преобразовать в Task через AsTask, если результат нужно переиспользовать."
        },
        new
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000044"),
            Topic = Topic.CSharp,
            Difficulty = Difficulty.MiddlePlus,
            Text = """
                   Скомпилируется ли код?

                   lock (_sync)
                   {
                       await SaveAsync();
                   }

                   Объясните причину и корректную альтернативу.
                   """,
            IdealAnswer = "Код не скомпилируется: await запрещён внутри lock, потому что monitor привязан к синхронному потоку выполнения. Для асинхронной взаимной блокировки используют SemaphoreSlim.WaitAsync и освобождают semaphore в finally."
        },
        new
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000045"),
            Topic = Topic.CSharp,
            Difficulty = Difficulty.Senior,
            Text = """
                   Проанализируйте код:

                   var lazy = cache.GetOrAdd(
                       key,
                       _ => CreateExpensiveValue());

                   Гарантирует ли ConcurrentDictionary, что CreateExpensiveValue вызовется один раз?
                   """,
            IdealAnswer = "Нет. GetOrAdd атомарно выбирает одно значение для словаря, но value factory может параллельно выполниться несколько раз. Для единственного вычисления хранят Lazy<T> или Task<T>, а сама factory не должна иметь необратимых side effects."
        },
        new
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000046"),
            Topic = Topic.CSharp,
            Difficulty = Difficulty.SeniorPlus,
            Text = """
                   Что не так с методом?

                   public async Task<ReadOnlySpan<byte>> ReadAsync()
                   {
                       var bytes = await File.ReadAllBytesAsync("data.bin");
                       return bytes;
                   }
                   """,
            IdealAnswer = "Такой async-метод не может возвращать ReadOnlySpan<byte>: ref struct не должен пересекать async-границу и храниться в state machine. Следует вернуть byte[] или ReadOnlyMemory<byte>, а Span получить позже в синхронном участке."
        },
        new
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000047"),
            Topic = Topic.CSharp,
            Difficulty = Difficulty.Senior,
            Text = """
                   Проанализируйте обработку ошибок:

                   try
                   {
                       await Task.WhenAll(firstTask, secondTask);
                   }
                   catch (Exception ex)
                   {
                       logger.LogError(ex, "Failed");
                   }

                   Почему лог может не показать все причины?
                   """,
            IdealAnswer = "Обе задачи завершаются, но await обычно пробрасывает одно исключение. Все ошибки находятся в Exception завершённого Task, возвращённого WhenAll. Его нужно сохранить в переменную и после catch анализировать allTask.Exception.InnerExceptions, сохраняя исходную семантику отмены."
        },
        new
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000048"),
            Topic = Topic.CSharp,
            Difficulty = Difficulty.Senior,
            Text = """
                   Проанализируйте метод:

                   public async void Process()
                   {
                       await SaveAsync();
                       throw new InvalidOperationException();
                   }

                   Почему сигнатура опасна вне event handler?
                   """,
            IdealAnswer = "async void нельзя await-ить, вызывающий код не получает Task и не может наблюдать завершение или ошибку. Исключение отправляется в текущий SynchronizationContext либо завершает процесс. Обычные асинхронные методы должны возвращать Task."
        },
        new
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000049"),
            Topic = Topic.CSharp,
            Difficulty = Difficulty.SeniorPlus,
            Text = """
                   Найдите проблему lifetime:

                   public void Start(IServiceScope scope)
                   {
                       _ = Task.Run(async () =>
                           await scope.ServiceProvider
                               .GetRequiredService<Worker>()
                               .RunAsync());
                   }
                   """,
            IdealAnswer = "Fire-and-forget задача использует scope, lifetime которого может закончиться раньше RunAsync. Это приводит к ObjectDisposedException и потерянным ошибкам. Работу передают управляемой background queue, а consumer создаёт собственный scope и наблюдает результат."
        },
        new
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000050"),
            Topic = Topic.CSharp,
            Difficulty = Difficulty.SeniorPlus,
            Text = """
                   Почему объект Subscriber может не собираться GC?

                   public void Subscribe(Publisher publisher)
                   {
                       publisher.Changed += HandleChanged;
                   }
                   """,
            IdealAnswer = "Publisher хранит delegate, а он содержит сильную ссылку на Subscriber. Если Publisher живёт дольше, Subscriber остаётся достижимым для GC. Нужна симметричная отписка, IDisposable-токен подписки или другая явная модель lifetime."
        }
    ];
}
