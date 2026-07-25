using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Quiz.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BalanceAnswerLengthsAndAddCodeAnalysis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000011"),
                column: "text",
                value: "IEnumerable<T> выполняет дальнейшие операции в памяти через LINQ to Objects.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000022"),
                column: "text",
                value: "Компилятор преобразует async-метод в конечный автомат.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000033"),
                column: "text",
                value: "Class подходит для объектов с идентичностью и изменяемым жизненным циклом.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000044"),
                column: "text",
                value: "Span<T> — безаллокационный view непрерывной памяти с lifetime-ограничениями.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000051"),
                column: "text",
                value: "CancellationToken передают по всей цепочке и проверяют в поддерживающих его API.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000062"),
                column: "text",
                value: "GC поколений оптимизирует короткоживущие объекты, а крупные размещает в LOH.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000073"),
                column: "text",
                value: "Долгое pinning запрещает GC перемещать объекты и фрагментирует управляемую кучу.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000084"),
                column: "text",
                value: "ThreadPool starvation проявляется очередями работ и ростом latency при умеренном CPU.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000091"),
                column: "text",
                value: "ValueTask оправдан в горячем API, которое часто завершается синхронно.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000102"),
                column: "text",
                value: "out разрешает использовать IEnumerable<Dog> как IEnumerable<Animal>, а in — наоборот.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000113"),
                column: "text",
                value: "Если Equals возвращает true, hash code обязан совпадать; обратное не требуется.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000124"),
                column: "text",
                value: "Dispose освобождает только принадлежащие объекту ресурсы и должен быть идемпотентным.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000131"),
                column: "text",
                value: "lock подходит для короткой синхронной критической секции без await.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000142"),
                column: "text",
                value: "volatile обеспечивает видимость чтений и записей, но не атомарность составных операций.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000153"),
                column: "text",
                value: "Неизменяемый снимок строят целиком и публикуют атомарной заменой ссылки.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000164"),
                column: "text",
                value: "Reflection переносит ошибки в runtime и усложняет trimming, AOT и горячие пути.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000171"),
                column: "text",
                value: "Tiered JIT ускоряет старт, а dynamic PGO специализирует горячий код по профилю.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000182"),
                column: "text",
                value: "Долгоживущий publisher через delegate удерживает subscriber сильной ссылкой.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000193"),
                column: "text",
                value: "Исключения дороги и не подходят для ожидаемого управления потоком выполнения.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000204"),
                column: "text",
                value: "NRT — статический анализ nullability, а не runtime-гарантия отсутствия null.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000211"),
                column: "text",
                value: "Захват локальных переменных в lambda обычно создаёт closure и дополнительную аллокацию.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000222"),
                column: "text",
                value: "Deferred LINQ выполняется при перечислении и может повторить I/O или вычисления.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000233"),
                column: "text",
                value: "Task.WhenAll ждёт все задачи; await обычно пробрасывает одну из накопленных ошибок.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000244"),
                column: "text",
                value: "Bounded Channel ограничивает очередь и создаёт backpressure для быстрого producer.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000251"),
                column: "text",
                value: "SafeHandle надёжно освобождает native handle даже при исключениях и финализации.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000262"),
                column: "text",
                value: "Generic со значимым типом обычно избегает boxing благодаря специализации runtime.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000273"),
                column: "text",
                value: "in и ref readonly уменьшают копирование крупных struct без права их изменения.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000284"),
                column: "text",
                value: "Value object неизменяем, валиден с момента создания и сравнивается по значению.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000291"),
                column: "text",
                value: "Sync-over-async создаёт deadlock в context или ThreadPool starvation на сервере.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000302"),
                column: "text",
                value: "Retry применяют к транзиентным идемпотентным операциям с backoff, jitter и timeout.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000313"),
                column: "text",
                value: "Локальное время неоднозначно при переходах DST и зависит от timezone машины.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000324"),
                column: "text",
                value: "Random.Shared потокобезопасен и подходит для некриптографических случайных значений.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000331"),
                column: "text",
                value: "Внутри catch оператор throw сохраняет исходный stack trace, а throw ex его повреждает.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000342"),
                column: "text",
                value: "Обычный массив проще и безопаснее для долгоживущих данных.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000353"),
                column: "text",
                value: "False sharing создаёт coherence traffic между независимыми данными одной cache line.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000364"),
                column: "text",
                value: "BackgroundService учитывает stoppingToken и при shutdown дренирует текущую работу.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000371"),
                column: "text",
                value: "Fire-and-forget скрывает завершение и может пережить захваченный scope.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000382"),
                column: "text",
                value: "GetOrAdd может вызвать factory параллельно несколько раз, поэтому side effects опасны.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000393"),
                column: "text",
                value: "IAsyncEnumerable отдаёт элементы по готовности и создаёт backpressure через MoveNextAsync.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000404"),
                column: "text",
                value: "Утечку ищут, разделяя managed heap, native memory, working set и кэши.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000011"),
                column: "text",
                value: "Tracking-запросы помещают сущности в ChangeTracker, поддерживают identity resolution и позволяют сохранить изменения через SaveChanges.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000022"),
                column: "text",
                value: "N+1 возникает, когда после одного запроса списка выполняется отдельный запрос для каждой записи.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000033"),
                column: "text",
                value: "Include нужен, когда требуется материализовать и изменять граф доменных сущностей.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000044"),
                column: "text",
                value: "В модель добавляют concurrency token, часто rowversion или явно управляемую версию.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000051"),
                column: "text",
                value: "DbContext представляет unit of work и обычно живёт в рамках одной операции.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000062"),
                column: "text",
                value: "Single query может породить cartesian explosion при нескольких коллекциях Include и передать много дублированных данных.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000073"),
                column: "text",
                value: "Вместо Skip страница фильтруется по последнему уникально упорядоченному ключу, например CreatedAt < cursorDate либо лексикографической паре CreatedAt/Id.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000084"),
                column: "text",
                value: "Pooling переиспользует экземпляры DbContext и уменьшает стоимость инициализации.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000091"),
                column: "text",
                value: "Compiled query уменьшает overhead анализа expression tree и поиска в query cache в очень горячем повторяющемся запросе одной формы.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000102"),
                column: "text",
                value: "Константы, динамически встроенные в expression tree, создают новые формы запросов и могут загрязнять кэши EF и БД.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000113"),
                column: "text",
                value: "DetectChanges сравнивает tracked-граф с original values и при большом числе сущностей вызывается многократно некоторыми API.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000124"),
                column: "text",
                value: "Они формируют set-based SQL и не загружают сущности в память, поэтому эффективны для массовых изменений.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000131"),
                column: "text",
                value: "Retry должен повторять весь логический блок как единицу, иначе состояние после частичного выполнения неопределённо.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000142"),
                column: "text",
                value: "Один вызов SaveChanges обычно выполняется атомарно в транзакции провайдера.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000153"),
                column: "text",
                value: "Перед SaveChanges EF может создать savepoint, чтобы при ошибке откатить только этот вызов и оставить транзакцию в пригодном состоянии, например для разрешения concurrency conflict.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000164"),
                column: "text",
                value: "Сначала определяют бизнес-политику: client wins, store wins или merge отдельных полей.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000171"),
                column: "text",
                value: "Для набора полей используют owned или complex type, а для одного столбца — value converter.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000182"),
                column: "text",
                value: "TPH хранит иерархию в одной таблице, обычно быстрее читает, но имеет nullable-столбцы и широкий ряд.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000193"),
                column: "text",
                value: "Не следует принимать entity целиком и помечать её Modified.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000204"),
                column: "text",
                value: "Tenant filter должен использовать контекстное значение безопасного scoped-сервиса и применяться ко всем tenant-owned сущностям.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000211"),
                column: "text",
                value: "Нужны глобальные фильтры, правила уникальности только среди активных строк, каскадная семантика, аудит и политика физической очистки.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000222"),
                column: "text",
                value: "Interceptor полезен для cross-cutting concerns: telemetry, command tagging, connection hooks или построение outbox на SaveChanges.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000233"),
                column: "text",
                value: "Значения всегда параметризуют через FromSqlInterpolated или параметры провайдера.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000244"),
                column: "text",
                value: "Он не проверяет SQL translation, ограничения, транзакции, collation, null semantics и поведение конкретного провайдера.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000251"),
                column: "text",
                value: "Применяют expand-contract: сначала добавляют совместимую nullable/default колонку, разворачивают код с dual read/write или backfill, затем переключают чтение и только в следующем релизе удаляют старую.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000262"),
                column: "text",
                value: "Несколько экземпляров могут одновременно менять схему, блокировать startup и получить разные результаты при частичной ошибке.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000273"),
                column: "text",
                value: "Начинают с сгенерированного SQL и плана базы: порядок фильтров в LINQ сам по себе не задаёт порядок индекса.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000284"),
                column: "text",
                value: "JOIN двух sibling-коллекций создаёт произведение их строк: 10 элементов одной и 10 другой дают 100 строк на корень, хотя объектов меньше.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000291"),
                column: "text",
                value: "Batch уменьшает roundtrips, но слишком большой пакет увеличивает SQL, параметры, locks, memory и время транзакции.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000302"),
                column: "text",
                value: "Современный EF обычно выбрасывает исключение вне верхней client projection.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000313"),
                column: "text",
                value: "Проецируют сразу в DTO только нужные поля, применяют фильтр и пагинацию до materialization, используют AsNoTracking и избегают Include, если Select уже выражает форму.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000324"),
                column: "text",
                value: "Если read-only результат содержит повторные ссылки на одну сущность, обычный no-tracking создаст несколько экземпляров.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000331"),
                column: "text",
                value: "Owned dependents внутри агрегата логично удалять вместе с root, и cascade отражает это правило.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000342"),
                column: "text",
                value: "Domain events преобразуют в outbox rows и добавляют в тот же DbContext до SaveChanges.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000353"),
                column: "text",
                value: "DbContext уже реализует Unit of Work и repository-подобный доступ.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000364"),
                column: "text",
                value: "JSON удобен для атомарного вложенного документа с изменяемой схемой и редкими междокументными связями.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000371"),
                column: "text",
                value: "Отдельный read DbContext направляют на replica только для tolerant-to-staleness сценариев.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000382"),
                column: "text",
                value: "Кэшируют DTO/read model, задают ключ с tenant и параметрами, ограниченный TTL и размер.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000393"),
                column: "text",
                value: "Коррелируют trace запроса с EF command activity, фиксируют SQL, параметры, число roundtrips и время ожидания соединения.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000404"),
                column: "text",
                value: "Если экран постоянно требует тяжёлых joins, денормализации, истории или иной формы данных, сложность и нагрузка сигнализируют о специализированной проекции.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000011"),
                column: "text",
                value: "Direct маршрутизирует по точному routing key.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000022"),
                column: "text",
                value: "Сообщения публикуют как persistent в durable exchange/queue, используют publisher confirms.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000033"),
                column: "text",
                value: "Dead-letter exchange получает сообщения, которые были rejected/nacked без requeue, истекли по TTL или вытеснены ограничением длины очереди.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000044"),
                column: "text",
                value: "Prefetch ограничивает число неподтверждённых сообщений у consumer.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000051"),
                column: "text",
                value: "Очередь сохраняет порядок публикации, но несколько consumers, повторная доставка, nack/requeue и разное время обработки меняют наблюдаемый порядок завершения.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000062"),
                column: "text",
                value: "Ack сообщает broker, что consumer принял ответственность за доставку после успешной обработки.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000073"),
                column: "text",
                value: "Durable сохраняет определение очереди, persistent просит сохранить сообщение.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000084"),
                column: "text",
                value: "Quorum queue нужна для репликации, предсказуемого leader election и высокой сохранности данных.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000091"),
                column: "text",
                value: "Без кворума очередь не может безопасно подтвердить новые записи и сохранить consistency.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000102"),
                column: "text",
                value: "Сообщение получает устойчивый MessageId или business operation id.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000113"),
                column: "text",
                value: "Broker не может атомарно согласовать ack с произвольным side effect в другой системе.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000124"),
                column: "text",
                value: "Prefetch ограничивает число unacked сообщений на consumer.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000131"),
                column: "text",
                value: "Сообщение немедленно возвращается в ту же очередь и снова попадает тому же или другому consumer, потребляя CPU и network без паузы.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000142"),
                column: "text",
                value: "Consumer различает транзиентную и постоянную ошибку, ограничивает число повторов и переносит неисправимое сообщение в DLQ вместе с причиной и correlation metadata.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000153"),
                column: "text",
                value: "В classic queue сообщение за большим TTL в голове может задержать истёкшие сообщения позади него.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000164"),
                column: "text",
                value: "Publisher ставит mandatory и обрабатывает basic.return, одновременно используя confirms.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000171"),
                column: "text",
                value: "Нужно понимать, что старые channels закрыты, in-flight confirms и deliveries имеют неопределённый исход.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000182"),
                column: "text",
                value: "AMQP channel — логическая сессия с порядком frames и delivery tags.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000193"),
                column: "text",
                value: "Publisher отслеживает monotonically increasing publish sequence number и хранит диапазоны outstanding сообщений.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000204"),
                column: "text",
                value: "Stream хранит append-only log, поддерживает replay по offset, несколько независимых читателей и очень большой backlog.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000211"),
                column: "text",
                value: "Глобальный порядок теряется, но сохраняется внутри partition.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000222"),
                column: "text",
                value: "Контракт должен быть backward/forward совместим: добавляют optional поля с defaults, не меняют смысл существующих и версионируют breaking event type.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000233"),
                column: "text",
                value: "Domain event отражает внутреннюю модель и может меняться вместе с ней.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000244"),
                column: "text",
                value: "Outbox атомарно сохраняет бизнес-изменение и сообщение в одной БД.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000251"),
                column: "text",
                value: "События маршрутизируют по aggregate id в фиксированную partition/queue и обрабатывают её последовательно одним активным consumer.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000262"),
                column: "text",
                value: "Нужны rates publish/deliver/ack, число unacked, age старейшего сообщения, redelivery rate, consumer utilization, disk/memory alarms, confirm latency и connection/channel churn.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000273"),
                column: "text",
                value: "Сравнивают arrival rate и sustainable processing rate, возраст старейшего сообщения и прогноз drain time.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000284"),
                column: "text",
                value: "Broker применяет flow control и блокирует publishing connections.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000291"),
                column: "text",
                value: "Создание connection дорого, создаёт churn, нагрузку и может само усугубить отказ.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000302"),
                column: "text",
                value: "Сначала прекращают принимать новые deliveries или отменяют consumer, затем ждут завершения in-flight в пределах timeout и отправляют ack/nack.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000313"),
                column: "text",
                value: "Большие сообщения увеличивают memory, disk I/O, replication traffic, latency и время redelivery.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000324"),
                column: "text",
                value: "Одно событие должно выражать атомарный бизнес-факт, но transport batch может объединять публикацию или обработку ради throughput.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000331"),
                column: "text",
                value: "Unique inbox key в БД остаётся источником истины, потому что broker redelivery и network partition допускают конкуренцию.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000342"),
                column: "text",
                value: "Он даёт активного consumer с автоматическим failover и удобен, когда очередь должна обрабатываться последовательно.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000353"),
                column: "text",
                value: "Приоритет позволяет срочным сообщениям обгонять обычные.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000364"),
                column: "text",
                value: "Каждая очередь хранит состояние, метаданные, процессы и метрики.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000371"),
                column: "text",
                value: "Команда выражает намерение конкретному владельцу и может быть отклонена.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000382"),
                column: "text",
                value: "Если вызывающий блокируется в ожидании немедленного ответа, broker добавляет latency, correlation state, timeout и failure modes.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000393"),
                column: "text",
                value: "Интеграционные тесты должны убивать consumer после commit до ack, разрывать connection до confirm, давать duplicate/out-of-order payload, заполнять DLQ и имитировать недоступный downstream.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000404"),
                column: "text",
                value: "Минимально: message id, type/version, occurred time, correlation id, causation id и trace context.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000011"),
                column: "text",
                value: "MVCC хранит несколько версий строк, позволяя читателям и писателям меньше блокировать друг друга.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000022"),
                column: "text",
                value: "B-tree — универсальный выбор для равенства, диапазонов и сортировки.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000033"),
                column: "text",
                value: "Сравнивают estimated и actual rows, время узлов, число loops, способ доступа и операции сортировки/хеширования.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000044"),
                column: "text",
                value: "PostgreSQL предоставляет Read Committed, Repeatable Read и Serializable.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000051"),
                column: "text",
                value: "Последовательное чтение может быть дешевле для маленькой таблицы или низкой селективности.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000062"),
                column: "text",
                value: "Долгая transaction snapshot удерживает xmin, поэтому версии строк, потенциально видимые ей, нельзя удалить.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000073"),
                column: "text",
                value: "Обычный VACUUM помечает место reusable и обновляет visibility map без возврата файла ОС.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000084"),
                column: "text",
                value: "HOT возможен, когда изменяемые колонки не участвуют в индексах и новая версия строки помещается на той же heap page.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000091"),
                column: "text",
                value: "Индекс наиболее эффективен, когда ведущие колонки ограничены equality, затем идёт range/sort.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000102"),
                column: "text",
                value: "INCLUDE хранит payload-колонки, не участвующие в поисковом ключе, и может позволить index-only scan без расширения семантики ключа.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000113"),
                column: "text",
                value: "MVCC-видимость обычно хранится в heap, поэтому executor проверяет visibility map.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000124"),
                column: "text",
                value: "Partial index полезен для небольшого часто запрашиваемого подмножества, например active rows, уменьшая размер и write cost.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000131"),
                column: "text",
                value: "Они индексируют результат выражения, например lower(email).");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000142"),
                column: "text",
                value: "Обычная статистика считает колонки в основном независимо.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000153"),
                column: "text",
                value: "Nested loop хорош для малого outer input и индексного поиска во inner.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000164"),
                column: "text",
                value: "work_mem применяется на каждый sort/hash node и потенциально на каждого parallel worker.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000171"),
                column: "text",
                value: "Это число строк, прочитанных узлом, но отброшенных его filter.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000182"),
                column: "text",
                value: "ANALYZE реально выполняет statement, поэтому UPDATE/DELETE/INSERT изменит данные и может долго блокировать.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000193"),
                column: "text",
                value: "Для распределения с сильным skew оптимальный plan зависит от значения параметра.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000204"),
                column: "text",
                value: "Ожидающие locks образуют очередь, и одна длинная транзакция может блокировать множество запросов.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000211"),
                column: "text",
                value: "Deadlock — цикл ожиданий, который PostgreSQL обнаруживает после deadlock_timeout и прерывает одну транзакцию.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000222"),
                column: "text",
                value: "Он блокирует выбранные строки от конкурентного изменения и подходит для read-modify-write.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000233"),
                column: "text",
                value: "PostgreSQL использует Serializable Snapshot Isolation и отслеживает опасные зависимости, не превращая все чтения в blocking locks.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000244"),
                column: "text",
                value: "Каждый statement получает новый snapshot на начало statement.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000251"),
                column: "text",
                value: "Они дают application-defined ключ и не привязаны автоматически к строке.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000262"),
                column: "text",
                value: "INSERT ...");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000273"),
                column: "text",
                value: "Ключ должен поддерживать pruning основных запросов, lifecycle данных и равномерное распределение.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000284"),
                column: "text",
                value: "Она помогает, когда pruning исключает большую часть данных или облегчает maintenance.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000291"),
                column: "text",
                value: "Если таблица partitioned по времени, detach/drop старой partition почти мгновенно освобождает логический объём и избегает миллионов row deletes/WAL.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000302"),
                column: "text",
                value: "Physical streaming передаёт WAL на уровне кластера, хорошо подходит HA и read replicas той же major-совместимой системы.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000313"),
                column: "text",
                value: "RPO — допустимая потеря данных; async replica имеет ненулевой RPO, synchronous commit может приблизить его к нулю ценой latency/availability.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000324"),
                column: "text",
                value: "Успешно записанный архив может быть неполным, несовместимым, повреждённым или не включать нужный WAL для PITR.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000331"),
                column: "text",
                value: "Изменения сначала записываются в WAL для durability и recovery.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000342"),
                column: "text",
                value: "Checkpoint вынуждает сбрасывать множество dirty pages и после него первые изменения страниц могут генерировать full-page images.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000353"),
                column: "text",
                value: "Каждое backend connection — процесс с памятью и потенциальным work_mem.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000364"),
                column: "text",
                value: "Клиент получает разные backend между транзакциями, поэтому session-level SET, advisory locks, temp tables, LISTEN и некоторые prepared statement assumptions ломаются.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000371"),
                column: "text",
                value: "BRIN хранит summary диапазонов страниц и очень мал, поэтому хорош для огромных append-mostly таблиц, где значение физически коррелирует с порядком, например timestamp.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000382"),
                column: "text",
                value: "GIN инвертирует элементы и обычно быстрее ищет containment/full-text.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000393"),
                column: "text",
                value: "Если conversion требует rewrite, PostgreSQL переписывает все строки под сильной блокировкой и генерирует WAL.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000404"),
                column: "text",
                value: "Сравнивают старый и новый plan, estimated/actual rows, статистику и распределение значений.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000011"),
                column: "text",
                value: "Агрегат — граница строгой согласованности и транзакции.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000022"),
                column: "text",
                value: "CQRS полезен, когда модели чтения и изменения заметно различаются, нужны независимое масштабирование, сложные бизнес-команды или разные требования к консистентности.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000033"),
                column: "text",
                value: "Выбор зависит от организационных границ, независимого масштабирования, скорости изменений и операционной зрелости.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000044"),
                column: "text",
                value: "Изменение бизнес-данных и запись сообщения outbox выполняются в одной локальной транзакции.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000051"),
                column: "text",
                value: "Операция должна давать один бизнес-результат при повторном запросе.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000062"),
                column: "text",
                value: "Bounded context — граница модели и языка, где термины имеют однозначный смысл.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000073"),
                column: "text",
                value: "Invariant — правило, которое должно быть истинно после каждой успешной команды.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000084"),
                column: "text",
                value: "Когда бизнес допускает промежуточное состояние и имеет ясное окно, статус и способ разрешения конфликта: например заказ принят, резерв ожидается.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000091"),
                column: "text",
                value: "Saga разбивает процесс на локальные транзакции и компенсирующие действия.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000102"),
                column: "text",
                value: "Она связывает availability и latency участников, усложняет recovery и часто не поддерживается внешними системами.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000113"),
                column: "text",
                value: "Если изменение внутренней модели одного постоянно заставляет менять другой, общий контракт содержит чужие сущности или low-level слой диктует use case, зависимость направлена не по policy.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000124"),
                column: "text",
                value: "Она направляет зависимости к policy, изолирует use cases от UI, БД и frameworks и облегчает тестирование заменяемых деталей.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000131"),
                column: "text",
                value: "Write-side repository восстанавливает aggregate root для выполнения поведения и скрывает persistence.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000142"),
                column: "text",
                value: "Domain event фиксирует факт внутри модели; handlers могут обновить локальное состояние до commit или подготовить outbox.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000153"),
                column: "text",
                value: "Сначала проверяют, действительно ли правило должно быть атомарным.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000164"),
                column: "text",
                value: "Единый язык связывает разговор с экспертом, модель, команды, события и код, уменьшая перевод и неоднозначность.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000171"),
                column: "text",
                value: "Если entities — набор setters, а правила размазаны по services, инварианты легко обходятся и модель анемична.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000182"),
                column: "text",
                value: "Когда доменные границы ещё уточняются, команда невелика и независимый deployment не окупает distributed cost.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000193"),
                column: "text",
                value: "Независимый ownership и cadence, отдельное масштабирование, security/isolation, иной availability requirement или стабильная bounded-context граница.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000204"),
                column: "text",
                value: "Компоненты связаны не только ссылками, но и общим значением, порядком, алгоритмом, временем или идентичностью.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000211"),
                column: "text",
                value: "Контракт делают ориентированным на capability, добавляют optional поля, сохраняют семантику и применяют tolerant reader.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000222"),
                column: "text",
                value: "Все retries одного намерения должны нести один ключ, иначе сервер не отличит повтор от новой операции.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000233"),
                column: "text",
                value: "Timeout ограничивает одну попытку, retry повторяет вероятно транзиентный сбой, circuit breaker временно прекращает вызовы к явно нездоровой зависимости.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000244"),
                column: "text",
                value: "Bulkhead разделяет ограниченные ресурсы, чтобы отказ одного workload/tenant/dependency не исчерпал все threads, connections или queue capacity.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000251"),
                column: "text",
                value: "Когда downstream насыщен, upstream должен замедлиться, получить явный reject/429 или сбросить нагрузку по политике.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000262"),
                column: "text",
                value: "SLI — измеряемая доля хороших событий, например запросы быстрее 300 мс без 5xx.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000273"),
                column: "text",
                value: "Среднее скрывает tail, который определяет опыт многих пользователей и усиливается при fan-out: максимум нескольких downstream растёт.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000284"),
                column: "text",
                value: "Trace связывает causality через сервисы и очереди, показывает critical path и fan-out.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000291"),
                column: "text",
                value: "Модель выбирают по риску и масштабу: shared tables с tenant key, schema-per-tenant или database-per-tenant.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000302"),
                column: "text",
                value: "Приложение сначала читает кэш, при miss — источник и заполняет кэш.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000313"),
                column: "text",
                value: "Используют per-key request coalescing/single-flight, jittered TTL, background refresh и stale-while-revalidate.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000324"),
                column: "text",
                value: "Когда история изменений является бизнес-ценностью, нужны temporal queries/audit, сложные процессы или восстановление новых projections.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000331"),
                column: "text",
                value: "Старые события остаются фактом и обычно не переписываются.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000342"),
                column: "text",
                value: "Snapshot — производительная оптимизация, не источник истины.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000353"),
                column: "text",
                value: "ACL переводит модель внешней или legacy-системы в язык собственного bounded context и не даёт чужим понятиям проникнуть внутрь.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000364"),
                column: "text",
                value: "Он фиксирует bounded contexts и отношения upstream/downstream: partnership, customer-supplier, conformist, ACL, published language и другие.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000371"),
                column: "text",
                value: "Сервисы обходят API друг друга, связываются схемой и транзакциями, миграции требуют координации.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000382"),
                column: "text",
                value: "Трафик и capabilities переносят небольшими вертикальными срезами через facade/router, сохраняя работающий legacy для остального.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000393"),
                column: "text",
                value: "ADR кратко фиксирует контекст, решение, альтернативы, последствия и статус на момент выбора.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000404"),
                column: "text",
                value: "Сравнивают не только лицензию, но и time-to-value, операционную зрелость, integration cost, lock-in, compliance, roadmap и стоимость владения/миграции.");

            migrationBuilder.InsertData(
                table: "questions",
                columns: new[] { "id", "difficulty", "ideal_answer", "text", "topic" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000041"), "MiddlePlus", "Будет выведено 333. Lambda захватывает одну переменную i, а не её значение на каждой итерации; к моменту вызова actions цикл завершён и i равна 3. Для фиксации значения внутри цикла создают локальную копию: var copy = i.", "Проанализируйте код:\n\nvar actions = new List<Action>();\nfor (var i = 0; i < 3; i++)\n    actions.Add(() => Console.Write(i));\n\nforeach (var action in actions)\n    action();\n\nЧто будет выведено и почему?", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000042"), "MiddlePlus", "В ASP.NET Core обычно нет SynchronizationContext, поэтому классический UI-deadlock не гарантирован. Однако .Result блокирует worker ThreadPool; под нагрузкой это создаёт starvation и резкий рост latency. Цепочку следует сделать асинхронной и использовать await.", "Проанализируйте код ASP.NET Core:\n\npublic string Get()\n{\n    return LoadAsync().Result;\n}\n\nКакой основной production-риск создаёт этот код?", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000043"), "Senior", "ValueTask может быть backed обычным Task, но также одноразовым IValueTaskSource. Во втором случае повторный await нарушает контракт и может дать исключение или неопределённое поведение. ValueTask следует await-ить один раз либо преобразовать в Task через AsTask, если результат нужно переиспользовать.", "Проанализируйте код:\n\nValueTask<int> operation = ReadAsync();\nvar first = await operation;\nvar second = await operation;\n\nПочему такой код нельзя считать безопасным для любого ValueTask?", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000044"), "MiddlePlus", "Код не скомпилируется: await запрещён внутри lock, потому что monitor привязан к синхронному потоку выполнения. Для асинхронной взаимной блокировки используют SemaphoreSlim.WaitAsync и освобождают semaphore в finally.", "Скомпилируется ли код?\n\nlock (_sync)\n{\n    await SaveAsync();\n}\n\nОбъясните причину и корректную альтернативу.", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000045"), "Senior", "Нет. GetOrAdd атомарно выбирает одно значение для словаря, но value factory может параллельно выполниться несколько раз. Для единственного вычисления хранят Lazy<T> или Task<T>, а сама factory не должна иметь необратимых side effects.", "Проанализируйте код:\n\nvar lazy = cache.GetOrAdd(\n    key,\n    _ => CreateExpensiveValue());\n\nГарантирует ли ConcurrentDictionary, что CreateExpensiveValue вызовется один раз?", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000046"), "SeniorPlus", "Такой async-метод не может возвращать ReadOnlySpan<byte>: ref struct не должен пересекать async-границу и храниться в state machine. Следует вернуть byte[] или ReadOnlyMemory<byte>, а Span получить позже в синхронном участке.", "Что не так с методом?\n\npublic async Task<ReadOnlySpan<byte>> ReadAsync()\n{\n    var bytes = await File.ReadAllBytesAsync(\"data.bin\");\n    return bytes;\n}", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000047"), "Senior", "Обе задачи завершаются, но await обычно пробрасывает одно исключение. Все ошибки находятся в Exception завершённого Task, возвращённого WhenAll. Его нужно сохранить в переменную и после catch анализировать allTask.Exception.InnerExceptions, сохраняя исходную семантику отмены.", "Проанализируйте обработку ошибок:\n\ntry\n{\n    await Task.WhenAll(firstTask, secondTask);\n}\ncatch (Exception ex)\n{\n    logger.LogError(ex, \"Failed\");\n}\n\nПочему лог может не показать все причины?", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000048"), "Senior", "async void нельзя await-ить, вызывающий код не получает Task и не может наблюдать завершение или ошибку. Исключение отправляется в текущий SynchronizationContext либо завершает процесс. Обычные асинхронные методы должны возвращать Task.", "Проанализируйте метод:\n\npublic async void Process()\n{\n    await SaveAsync();\n    throw new InvalidOperationException();\n}\n\nПочему сигнатура опасна вне event handler?", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000049"), "SeniorPlus", "Fire-and-forget задача использует scope, lifetime которого может закончиться раньше RunAsync. Это приводит к ObjectDisposedException и потерянным ошибкам. Работу передают управляемой background queue, а consumer создаёт собственный scope и наблюдает результат.", "Найдите проблему lifetime:\n\npublic void Start(IServiceScope scope)\n{\n    _ = Task.Run(async () =>\n        await scope.ServiceProvider\n            .GetRequiredService<Worker>()\n            .RunAsync());\n}", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000050"), "SeniorPlus", "Publisher хранит delegate, а он содержит сильную ссылку на Subscriber. Если Publisher живёт дольше, Subscriber остаётся достижимым для GC. Нужна симметричная отписка, IDisposable-токен подписки или другая явная модель lifetime.", "Почему объект Subscriber может не собираться GC?\n\npublic void Subscribe(Publisher publisher)\n{\n    publisher.Changed += HandleChanged;\n}", "CSharp" }
                });

            migrationBuilder.InsertData(
                table: "answer_options",
                columns: new[] { "id", "explanation", "is_correct", "question_id", "text" },
                values: new object[,]
                {
                    { new Guid("21000000-0000-0000-0000-000000000411"), "Этот вариант напрямую отвечает на поставленный вопрос и учитывает ключевые ограничения и компромиссы.", true, new Guid("10000000-0000-0000-0000-000000000041"), "Будет выведено 333: все лямбды захватывают одну переменную i, равную 3 к моменту вызова." },
                    { new Guid("21000000-0000-0000-0000-000000000412"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000041"), "Будет выведено 012: каждая лямбда автоматически получает копию i для своей итерации." },
                    { new Guid("21000000-0000-0000-0000-000000000413"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000041"), "Будет выведено 000: замыкание фиксирует начальное значение i в момент создания первой лямбды." },
                    { new Guid("21000000-0000-0000-0000-000000000414"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000041"), "Код не скомпилируется, потому что переменную цикла нельзя захватывать внутри lambda expression." },
                    { new Guid("21000000-0000-0000-0000-000000000421"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000042"), ".Result гарантированно создаст deadlock, потому что ASP.NET Core всегда возвращает continuation в request thread." },
                    { new Guid("21000000-0000-0000-0000-000000000422"), "Этот вариант напрямую отвечает на поставленный вопрос и учитывает ключевые ограничения и компромиссы.", true, new Guid("10000000-0000-0000-0000-000000000042"), ".Result блокирует поток ThreadPool и под нагрузкой может вызвать starvation и резкий рост latency." },
                    { new Guid("21000000-0000-0000-0000-000000000423"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000042"), "Блокировка безопасна: runtime автоматически заменяет .Result на await при выполнении асинхронного метода." },
                    { new Guid("21000000-0000-0000-0000-000000000424"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000042"), "Единственный риск — лишняя аллокация Task; число доступных потоков и latency запроса не изменятся." },
                    { new Guid("21000000-0000-0000-0000-000000000431"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000043"), "Повторный await всегда разрешён, потому что ValueTask является обычным immutable wrapper над Task." },
                    { new Guid("21000000-0000-0000-0000-000000000432"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000043"), "Второй await не компилируется: компилятор помечает локальную переменную ValueTask как уже использованную." },
                    { new Guid("21000000-0000-0000-0000-000000000433"), "Этот вариант напрямую отвечает на поставленный вопрос и учитывает ключевые ограничения и компромиссы.", true, new Guid("10000000-0000-0000-0000-000000000043"), "Повторный await небезопасен: ValueTask может опираться на одноразовый IValueTaskSource." },
                    { new Guid("21000000-0000-0000-0000-000000000434"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000043"), "Повторное ожидание безопасно только после вызова Preserve, который входит в публичный API любого ValueTask." },
                    { new Guid("21000000-0000-0000-0000-000000000441"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000044"), "Код компилируется, а monitor автоматически освобождается перед await и повторно захватывается после него." },
                    { new Guid("21000000-0000-0000-0000-000000000442"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000044"), "Код компилируется, но при первом await всегда возникает SynchronizationLockException во время выполнения." },
                    { new Guid("21000000-0000-0000-0000-000000000443"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000044"), "Достаточно заменить lock на Monitor.Enter: monitor допускает асинхронное продолжение на другом потоке." },
                    { new Guid("21000000-0000-0000-0000-000000000444"), "Этот вариант напрямую отвечает на поставленный вопрос и учитывает ключевые ограничения и компромиссы.", true, new Guid("10000000-0000-0000-0000-000000000044"), "Код не компилируется; для асинхронной блокировки нужен SemaphoreSlim с WaitAsync и Release в finally." },
                    { new Guid("21000000-0000-0000-0000-000000000451"), "Этот вариант напрямую отвечает на поставленный вопрос и учитывает ключевые ограничения и компромиссы.", true, new Guid("10000000-0000-0000-0000-000000000045"), "Нет: GetOrAdd атомарно выбирает значение, но его value factory может выполниться несколько раз." },
                    { new Guid("21000000-0000-0000-0000-000000000452"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000045"), "Да: GetOrAdd сериализует вызовы value factory и запускает её ровно один раз для каждого ключа." },
                    { new Guid("21000000-0000-0000-0000-000000000453"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000045"), "Factory выполняется несколько раз только тогда, когда первый вызов завершился исключением." },
                    { new Guid("21000000-0000-0000-0000-000000000454"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000045"), "Factory всегда выполняется под глобальной блокировкой словаря, поэтому side effects в ней безопасны." },
                    { new Guid("21000000-0000-0000-0000-000000000461"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000046"), "Метод корректен: compiler автоматически превращает ReadOnlySpan<byte> в массив внутри async state machine." },
                    { new Guid("21000000-0000-0000-0000-000000000462"), "Этот вариант напрямую отвечает на поставленный вопрос и учитывает ключевые ограничения и компромиссы.", true, new Guid("10000000-0000-0000-0000-000000000046"), "Метод не компилируется: ReadOnlySpan<byte> как ref struct нельзя переносить через async-границу." },
                    { new Guid("21000000-0000-0000-0000-000000000463"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000046"), "Метод скомпилируется только в Release, где JIT закрепит массив и сохранит Span между продолжениями." },
                    { new Guid("21000000-0000-0000-0000-000000000464"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000046"), "Проблема только в чтении файла: если заменить File API на MemoryStream, возвращать Span станет безопасно." },
                    { new Guid("21000000-0000-0000-0000-000000000471"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000047"), "Task.WhenAll прекращает ждать после первой ошибки, поэтому исключения ещё работающих задач недоступны." },
                    { new Guid("21000000-0000-0000-0000-000000000472"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000047"), "Свойство Exception у задачи WhenAll также содержит только первую ошибку, выбранную по порядку запуска." },
                    { new Guid("21000000-0000-0000-0000-000000000473"), "Этот вариант напрямую отвечает на поставленный вопрос и учитывает ключевые ограничения и компромиссы.", true, new Guid("10000000-0000-0000-0000-000000000047"), "await обычно пробрасывает одну ошибку, а все причины нужно читать из Exception задачи Task.WhenAll." },
                    { new Guid("21000000-0000-0000-0000-000000000474"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000047"), "Все ошибки автоматически записываются в ex.InnerException, поэтому дополнительный анализ задачи не нужен." },
                    { new Guid("21000000-0000-0000-0000-000000000481"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000048"), "async void автоматически преобразуется в async Task, если метод вызывается не из обработчика события." },
                    { new Guid("21000000-0000-0000-0000-000000000482"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000048"), "Исключение сохраняется в неявном Task, который вызывающий код может получить через Task.CurrentId." },
                    { new Guid("21000000-0000-0000-0000-000000000483"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000048"), "Сигнатура безопасна: SynchronizationContext гарантированно возвращает исключение непосредственно вызывающему методу." },
                    { new Guid("21000000-0000-0000-0000-000000000484"), "Этот вариант напрямую отвечает на поставленный вопрос и учитывает ключевые ограничения и компромиссы.", true, new Guid("10000000-0000-0000-0000-000000000048"), "Вызывающий код не получает Task, поэтому не может ожидать Process и штатно обработать его исключение." },
                    { new Guid("21000000-0000-0000-0000-000000000491"), "Этот вариант напрямую отвечает на поставленный вопрос и учитывает ключевые ограничения и компромиссы.", true, new Guid("10000000-0000-0000-0000-000000000049"), "Фоновая задача может обратиться к scope после его уничтожения и потерять собственное исключение." },
                    { new Guid("21000000-0000-0000-0000-000000000492"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000049"), "Task.Run клонирует IServiceScope и продлевает lifetime всех scoped-сервисов до завершения delegate." },
                    { new Guid("21000000-0000-0000-0000-000000000493"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000049"), "Scope остаётся жив, пока lambda хранит ссылку на него, поэтому dispose владельца не влияет на Worker." },
                    { new Guid("21000000-0000-0000-0000-000000000494"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000049"), "Проблемы нет, потому что любой scoped-сервис автоматически потокобезопасен при запуске через Task.Run." },
                    { new Guid("21000000-0000-0000-0000-000000000501"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000050"), "Подписка на событие хранит weak reference, поэтому Publisher не влияет на время жизни Subscriber." },
                    { new Guid("21000000-0000-0000-0000-000000000502"), "Этот вариант напрямую отвечает на поставленный вопрос и учитывает ключевые ограничения и компромиссы.", true, new Guid("10000000-0000-0000-0000-000000000050"), "Publisher через delegate удерживает сильную ссылку на Subscriber, пока подписка не будет снята." },
                    { new Guid("21000000-0000-0000-0000-000000000503"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000050"), "GC игнорирует ссылки внутри delegate и может собрать Subscriber сразу после завершения Subscribe." },
                    { new Guid("21000000-0000-0000-0000-000000000504"), "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", false, new Guid("10000000-0000-0000-0000-000000000050"), "Утечка возможна только у lambda с captured variables; method group HandleChanged сильную ссылку не создаёт." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000411"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000412"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000413"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000414"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000421"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000422"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000423"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000424"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000431"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000432"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000433"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000434"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000441"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000442"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000443"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000444"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000451"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000452"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000453"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000454"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000461"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000462"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000463"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000464"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000471"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000472"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000473"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000474"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000481"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000482"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000483"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000484"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000491"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000492"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000493"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000494"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000501"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000502"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000503"));

            migrationBuilder.DeleteData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000504"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000050"));

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000011"),
                column: "text",
                value: "IEnumerable<T> выполняет дальнейшие операции в памяти через LINQ to Objects. IQueryable<T> хранит expression tree, который провайдер переводит во внешний запрос, например SQL. IQueryable не стоит выпускать за границы слоя данных: это размывает ответственность, усложняет тестирование и позволяет вызывающему сформировать неэффективный запрос.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000022"),
                column: "text",
                value: "Компилятор преобразует async-метод в конечный автомат. При незавершённой await-операции управление возвращается вызывающему коду, а продолжение планируется после завершения Task. Для I/O поток обычно не блокируется и новый поток не требуется; пул потоков нужен преимущественно для CPU-bound работы.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000033"),
                column: "text",
                value: "Class подходит для объектов с идентичностью и изменяемым жизненным циклом. Record удобен для value-like моделей и DTO благодаря value equality и with-выражениям. Struct стоит применять для небольших неизменяемых значений, которые часто создаются и не требуют наследования; крупные структуры увеличивают стоимость копирования.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000044"),
                column: "text",
                value: "Span<T> представляет непрерывный участок памяти без дополнительных аллокаций и может ссылаться на массив, stackalloc или unmanaged memory. Это ref struct, поэтому он не может храниться в heap-объекте, использоваться через await или yield. Memory<T> можно хранить в объектах и передавать через async-границы, получая Span при синхронной обработке.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000051"),
                column: "text",
                value: "Токен передают по всей цепочке вызовов и регулярно проверяют через ThrowIfCancellationRequested либо прокидывают в поддерживающие его API. Владелец CancellationTokenSource отвечает за отмену и освобождение ресурса. OperationCanceledException не следует превращать в обычную ошибку: она отражает ожидаемое завершение по запросу.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000062"),
                column: "text",
                value: "Поколения 0–2 используют гипотезу о короткой жизни большинства объектов; крупные объекты попадают в LOH. Server GC создаёт heap и поток сборки на логический процессор и ориентирован на throughput, Workstation — на отзывчивость. Начинать нужно с allocation rate, % Time in GC, pause duration, размера поколений и LOH, затем подтверждать причину через dotnet-counters, trace или dump.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000073"),
                column: "text",
                value: "Pinned-объект нельзя перемещать при compaction, поэтому множество долгоживущих закреплений фрагментирует heap и повышает стоимость GC. Pinning оправдан на короткой границе с native API или I/O; для долгих буферов лучше использовать специализированные пулы, pinned object heap либо unmanaged memory и явно контролировать время жизни.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000084"),
                column: "text",
                value: "При starvation запросы ждут свободный worker, latency растёт, а CPU может оставаться умеренным; типичные причины — sync-over-async, блокирующие I/O и долгие locks. Проверяют очередь ThreadPool, число потоков, request latency и stacks через dotnet-counters, dotnet-stack или trace. Исправление — асинхронность по всей цепочке, устранение блокировок и ограничение параллелизма, а не бездумное увеличение MinThreads.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000091"),
                column: "text",
                value: "ValueTask полезен в очень горячем API, которое часто завершается синхронно и где измерения показывают значимые аллокации Task. Его нельзя бездумно await-ить несколько раз, хранить или комбинировать как обычный Task; часто требуется AsTask. По умолчанию предпочтителен Task, а ValueTask вводят только после профилирования и с ясным контрактом.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000102"),
                column: "text",
                value: "Ковариантный out-параметр позволяет использовать источник более конкретного типа как источник базового, например IEnumerable<Dog> как IEnumerable<Animal>. Контравариантный in-параметр позволяет обработчику базового типа обслуживать конкретный, например IComparer<Animal> для Dog. Вариантность безопасна только для ссылочных типов и ограничивает позиции чтения и записи параметра.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000113"),
                column: "text",
                value: "Если Equals возвращает true, hash code обязан совпадать; обратное не требуется. Поля, участвующие в равенстве и hash code, нельзя менять, пока объект служит ключом, иначе запись станет логически недоступной. Для value object обычно задают структурное равенство, а entity сравнивают по устойчивой идентичности с осторожностью до её назначения.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000124"),
                column: "text",
                value: "Класс должен освобождать только ресурсы, которыми владеет, быть устойчивым к повторному Dispose и не выполнять работу после освобождения. IAsyncDisposable нужен, когда корректное закрытие требует async I/O; комбинированный тип обычно реализует оба пути и подавляет финализацию. Финализатор нужен только при прямом владении unmanaged-ресурсом, предпочтительно через SafeHandle.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000131"),
                column: "text",
                value: "lock подходит для короткой синхронной критической секции без await. SemaphoreSlim позволяет асинхронно ограничивать конкуренцию, ReaderWriterLockSlim полезен лишь при измеренном преобладании чтений и достаточной длительности операций. Channel<T> часто лучше общей блокировки, когда задачу можно представить как очередь с одним или несколькими потребителями и backpressure.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000142"),
                column: "text",
                value: "volatile задаёт семантику чтения и записи с барьерами видимости, но не делает составные операции вроде increment атомарными и не защищает инвариант нескольких полей. Interlocked подходит для атомарных операций над отдельным значением. Если переход состояния затрагивает несколько значений или требует проверки-изменения, нужен lock либо другая синхронизация.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000153"),
                column: "text",
                value: "Снимок полностью строят до публикации, не изменяют после неё и заменяют ссылку атомарно через Volatile.Write или Interlocked.Exchange. Читатели получают локальную копию ссылки через Volatile.Read и работают без блокировок. Важно, чтобы весь достижимый граф действительно был immutable, иначе безопасная публикация корня не устраняет внутренние гонки.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000164"),
                column: "text",
                value: "Reflection усложняет trimming/AOT, переносит ошибки в runtime и в горячих путях добавляет lookup, boxing и invocation overhead. Метаданные можно кэшировать, вызовы компилировать в delegates, а для сериализации, DI-регистрации и маппинга использовать source generators. Замена оправдана после измерений либо когда нужна статическая проверяемость и Native AOT.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000171"),
                column: "text",
                value: "Tiered compilation быстро запускает код и затем перекомпилирует горячие методы; dynamic PGO использует фактический профиль для специализации. Native AOT уменьшает startup и footprint, но ограничивает динамическую генерацию кода и reflection-сценарии. Поэтому оптимизируют по реальному режиму деплоя, прогревают benchmark и проверяют совместимость библиотек.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000182"),
                column: "text",
                value: "Publisher хранит сильную ссылку на delegate, а delegate — на subscriber, поэтому долгоживущий publisher удерживает подписчика. Нужно явно отписываться, возвращать IDisposable-токен подписки, привязывать время жизни объектов или применять weak-event только при понятной семантике. Анонимная lambda усложняет отписку, если её экземпляр не сохранён.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000193"),
                column: "text",
                value: "Создание и обработка исключения существенно дороже обычной ветки и искажает telemetry, если ожидаемые ситуации выглядят как ошибки. Для вероятного неуспеха лучше Try-методы, Result или явный union. Исключение остаётся правильным для нарушения контракта и действительно исключительного состояния, особенно когда вызывающий уровень может восстановиться.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000204"),
                column: "text",
                value: "NRT — статический анализ аннотаций, а не runtime-защита: он уменьшает число случайных null, но внешние данные, reflection, старые библиотеки и неверный оператор ! могут нарушить контракт. На границах всё равно нужна runtime-валидация. Аннотации следует согласовывать с доменной семантикой, а не отключать предупреждения массовыми подавлениями.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000211"),
                column: "text",
                value: "Lambda, захватывающая локальные переменные или this, обычно создаёт объект closure и delegate; в цикле это может стать заметным allocation rate. Помогают static lambda, передача state отдельным параметром и кэширование delegate. Но решение принимают по профилю или BenchmarkDotNet, потому что читаемость важнее микроскопической экономии вне горячего пути.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000222"),
                column: "text",
                value: "Запрос выполняется при перечислении, поэтому повторное перечисление может повторить дорогой I/O или увидеть уже изменённое состояние. Возврат ленивой последовательности за пределы lifetime DbContext приводит к сбоям, а side effects внутри Select делают поведение неочевидным. Границу материализации выбирают явно и документируют одноразовые последовательности.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000233"),
                column: "text",
                value: "Возвращаемый Task завершается после всех операций; при ошибках он Faulted, а Exception содержит aggregate внутренних ошибок, хотя await обычно пробрасывает одну. Остальные ошибки нужно анализировать через сам Task. Отмена не прекращает уже запущенную работу автоматически: всем операциям передают общий token и отдельно решают политику частичного результата.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000244"),
                column: "text",
                value: "Используют bounded Channel или очередь с ограниченной ёмкостью, чтобы быстрый producer ждал либо применял явную политику drop. Число consumers ограничивают по характеру работы, ошибки и завершение канала распространяют явно, CancellationToken проходит по всей цепочке. Метрики глубины очереди и времени ожидания показывают, где находится bottleneck.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000251"),
                column: "text",
                value: "SafeHandle инкапсулирует критический handle, корректно взаимодействует с GC и гарантирует освобождение даже при исключениях и сложной финализации. Собственный финализатор удлиняет жизнь объекта и легко содержит race или double-free. Управляемый wrapper обычно владеет SafeHandle и реализует Dispose без собственной небезопасной логики финализации.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000262"),
                column: "text",
                value: "Generic-код со значимым типом обычно работает без упаковки благодаря специализации runtime. Boxing возникает при приведении к object или интерфейсу, использовании негeneric API, некоторых вызовах constrained-методов и форматировании. Проверяют allocations профилировщиком; constraints и generic-интерфейсы помогают сохранить статический тип.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000273"),
                column: "text",
                value: "in и ref readonly позволяют передавать или возвращать ссылку без права изменения, что может снизить копирование крупных struct. scoped ограничивает escape ссылки временем жизни текущего scope и помогает компилятору предотвращать висячие ссылки. Для маленьких struct косвенный доступ может быть не быстрее, поэтому выбор подтверждают benchmark.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000284"),
                column: "text",
                value: "Value object делают неизменяемым, валидируют при создании и определяют равенство по всем значимым компонентам. Он не должен иметь отдельного жизненного цикла или изменяемой идентичности. Неизменяемость упрощает совместное использование между потоками, но вложенные коллекции тоже должны быть immutable или защищённо скопированы.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000291"),
                column: "text",
                value: "Блокировка потока до завершения async-операции может вызвать классический deadlock при захваченном context, а на сервере — ThreadPool starvation и резкий рост latency. Исключения также оборачиваются иначе. Правильное решение — async all the way; синхронную границу оставляют только при контролируемом startup-коде и ясных ограничениях.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000302"),
                column: "text",
                value: "Повторяют только транзиентные и идемпотентные операции, используют ограниченное число попыток, exponential backoff с jitter и общий timeout. CancellationToken должен прекращать ожидание. Retry без лимита создаёт retry storm, поэтому его сочетают с circuit breaker, ограничением конкуренции и наблюдаемостью причин.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000313"),
                column: "text",
                value: "Локальное время неоднозначно при переходах DST и зависит от timezone машины. Для событий и хранения обычно используют UTC через DateTimeOffset и внедряемый TimeProvider, а локализацию выполняют на границе отображения. Для измерения длительности нужен монотонный Stopwatch, потому что wall clock может корректироваться.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000324"),
                column: "text",
                value: "Для симуляций и некритичных значений используют Random.Shared, который безопасен для параллельного доступа. Токены, пароли, nonce и идентификаторы безопасности требуют RandomNumberGenerator. Seeded Random полезен для воспроизводимых тестов, но его предсказуемость делает его непригодным для защиты.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000331"),
                column: "text",
                value: "Внутри catch оператор throw сохраняет исходный stack trace, а throw ex его повреждает. Filter when позволяет классифицировать исключение без входа в catch и не меняет исходный стек; в нём не должно быть side effects. Перехватывают исключение только если добавляют контекст, выполняют восстановление или переводят его на осмысленную границу.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000342"),
                column: "text",
                value: "Обычный массив проще и безопаснее для долгоживущих данных. ArrayPool снижает давление на GC для частых временных буферов, но арендованный массив может быть больше запрошенного, содержит старые данные и обязан возвращаться в finally; чувствительные данные очищают. MemoryPool удобен для ownership-модели и pipelines, особенно с нестандартной памятью.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000353"),
                column: "text",
                value: "Независимые значения в одной cache line заставляют ядра постоянно инвалидировать кэш друг друга, поэтому масштабирование ухудшается без логической блокировки. Это видно в высококонкурентных счётчиках и массивах состояния. Помогают разбиение счётчиков, локальная агрегация и иногда padding, но подтверждать причину нужно аппаратными метриками и benchmark.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000364"),
                column: "text",
                value: "BackgroundService должен уважать stoppingToken, не запускать fire-and-forget работу без учёта и завершать приём новых задач до дренирования текущих. На остановке учитывают host shutdown timeout, корректно закрывают каналы и освобождают ресурсы. Необработанная ошибка фоновой задачи должна быть наблюдаемой и иметь явную политику остановки или восстановления.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000371"),
                column: "text",
                value: "Вызывающий код не наблюдает завершение и исключение, а захваченные scoped-сервисы могут быть уже освобождены. Задачу следует await-ить, передать управляемому background queue или зарегистрировать у компонента, который наблюдает результат и остановку. Если отделение намеренное, нужны собственный scope, logging, timeout и политика ошибок.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000382"),
                column: "text",
                value: "Value factory может выполниться несколько раз параллельно, хотя в словарь попадёт одно значение, поэтому она не должна иметь необратимых side effects. Для единственного вычисления хранят Lazy<T> или Task<T> с подходящим режимом синхронизации и решают, удалять ли faulted/cancelled значение для повторной попытки.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000393"),
                column: "text",
                value: "Он позволяет отдавать элементы по мере готовности без материализации всей коллекции и поддерживает естественный backpressure на уровне MoveNextAsync. Нужно передавать отмену через WithCancellation или EnumeratorCancellation, корректно освобождать enumerator и помнить, что ошибки могут возникнуть в середине перечисления. Источник не следует перечислять конкурентно без явного контракта.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000404"),
                column: "text",
                value: "Сначала разделяют managed heap, native memory, working set и кэши, наблюдая тренд после полных GC. Затем сравнивают heap dumps, ищут доминирующие типы и цепочки удержания, проверяют event subscriptions, static roots, timers и незавершённые Tasks. Важно воспроизвести нагрузку и доказать удержание объектов, а не судить только по диспетчеру задач.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000011"),
                column: "text",
                value: "Tracking-запросы помещают сущности в ChangeTracker, поддерживают identity resolution и позволяют сохранить изменения через SaveChanges. AsNoTracking уменьшает расход памяти и CPU для read-only сценариев. Для сложных read-only графов возможен AsNoTrackingWithIdentityResolution, который устраняет дубликаты объектов без постоянного tracking.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000022"),
                column: "text",
                value: "N+1 возникает, когда после одного запроса списка выполняется отдельный запрос для каждой записи. Её видно по логам SQL, профилировщику и метрикам количества запросов. Обычно помогают проекция Select, осознанный Include, пакетная загрузка и отключение неуместной lazy loading.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000033"),
                column: "text",
                value: "Include нужен, когда требуется материализовать и изменять граф доменных сущностей. Для чтения и API-ответов предпочтительнее Select в DTO: он выбирает только необходимые столбцы, уменьшает объём данных и часто формирует более простой SQL. Include не влияет на проекцию, если итоговый результат уже не является сущностью.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000044"),
                column: "text",
                value: "В модель добавляют concurrency token, часто rowversion или явно управляемую версию. EF включает исходное значение токена в условие UPDATE/DELETE и при конфликте выбрасывает DbUpdateConcurrencyException. Приложение должно выбрать стратегию: повтор, слияние изменений или сообщение пользователю.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000051"),
                column: "text",
                value: "DbContext представляет unit of work и обычно живёт в рамках одной операции. Он не является thread-safe: параллельные запросы и изменения одного экземпляра приводят к исключениям и повреждению состояния tracking. В долгоживущих процессах и Blazor Server применяют короткие scope, transient context или IDbContextFactory.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000062"),
                column: "text",
                value: "Single query может породить cartesian explosion при нескольких коллекциях Include и передать много дублированных данных. Split query выполняет несколько SQL-запросов и уменьшает дублирование, но добавляет roundtrips и без подходящей транзакции может увидеть несогласованные снимки. Выбор делают по форме графа, объёму данных и измеренному SQL.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000073"),
                column: "text",
                value: "Вместо Skip страница фильтруется по последнему уникально упорядоченному ключу, например CreatedAt < cursorDate либо лексикографической паре CreatedAt/Id. База продолжает чтение с позиции индекса и не пересчитывает все предыдущие строки. Нужен стабильный уникальный порядок и составной индекс, совпадающий с фильтром и сортировкой.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000084"),
                column: "text",
                value: "Pooling переиспользует экземпляры DbContext и уменьшает стоимость инициализации, но OnConfiguring обычно выполняется один раз. В context нельзя хранить request-specific состояние, tenant id или изменяемые флаги без гарантированного сброса. Пул не делает DbContext потокобезопасным и не заменяет pooling соединений драйвера.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000091"),
                column: "text",
                value: "Compiled query уменьшает overhead анализа expression tree и поиска в query cache в очень горячем повторяющемся запросе одной формы. Она не меняет план базы, индексы, число строк или network latency. Сначала оптимизируют SQL и roundtrips, затем benchmark показывает, значима ли доля самого EF.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000102"),
                column: "text",
                value: "Константы, динамически встроенные в expression tree, создают новые формы запросов и могут загрязнять кэши EF и БД. Значения нужно передавать как параметры, а динамические фильтры строить со стабильной структурой. Query cache hit rate и SQL-логи помогают увидеть постоянную перекомпиляцию.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000113"),
                column: "text",
                value: "DetectChanges сравнивает tracked-граф с original values и при большом числе сущностей вызывается многократно некоторыми API. Для контролируемого bulk-сценария его временно отключают, добавляют данные пакетами и вызывают DetectChanges явно перед SaveChanges. Это требует аккуратности: иначе изменения или связи могут не сохраниться.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000124"),
                column: "text",
                value: "Они формируют set-based SQL и не загружают сущности в память, поэтому эффективны для массовых изменений. Операция обходит ChangeTracker, доменные методы и его текущее состояние; tracked-объекты могут стать устаревшими. Инварианты, concurrency и транзакционную границу нужно обеспечить явно.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000131"),
                column: "text",
                value: "Retry должен повторять весь логический блок как единицу, иначе состояние после частичного выполнения неопределённо. Пользовательскую транзакцию создают внутри ExecuteAsync выбранной strategy и делают операции идемпотентными либо проверяемыми. Нельзя просто обернуть SaveChanges retry, если рядом есть внешние side effects.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000142"),
                column: "text",
                value: "Один вызов SaveChanges обычно выполняется атомарно в транзакции провайдера. Явная транзакция нужна, когда единый инвариант охватывает несколько SaveChanges, raw SQL или другие операции той же БД. Её держат короткой; внешние HTTP или broker-вызовы внутрь не помещают, применяя outbox.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000153"),
                column: "text",
                value: "Перед SaveChanges EF может создать savepoint, чтобы при ошибке откатить только этот вызов и оставить транзакцию в пригодном состоянии, например для разрешения concurrency conflict. Поддержка зависит от провайдера и настроек. Это не заменяет общую обработку ошибки и решение, можно ли безопасно продолжать.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000164"),
                column: "text",
                value: "Сначала определяют бизнес-политику: client wins, store wins или merge отдельных полей. Затем получают database values, обновляют original values и повторяют ограниченное число раз только безопасную транзакцию. Слепой retry без повторной проверки инварианта может перезаписать чужое изменение.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000171"),
                column: "text",
                value: "Для набора полей используют owned или complex type, а для одного столбца — value converter. Изменяемому преобразованному типу часто нужен ValueComparer, иначе ChangeTracker не увидит изменение. Конструктор и приватные свойства позволяют сохранить валидацию, но EF materialization не должен создавать недопустимое состояние.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000182"),
                column: "text",
                value: "TPH хранит иерархию в одной таблице, обычно быстрее читает, но имеет nullable-столбцы и широкий ряд. TPT нормализует типы, однако сложные запросы требуют множества joins. TPC дублирует базовые столбцы и хорошо читает конкретные типы, но усложняет общие ключи и изменения схемы. Выбор подтверждают реальными запросами.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000193"),
                column: "text",
                value: "Не следует принимать entity целиком и помечать её Modified. Загружают агрегат, применяют валидированную команду через доменные методы и сохраняют изменённые поля; для patch явно перечисляют разрешённые изменения. Concurrency token защищает от lost update, а DTO отделяет контракт от persistence-модели.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000204"),
                column: "text",
                value: "Tenant filter должен использовать контекстное значение безопасного scoped-сервиса и применяться ко всем tenant-owned сущностям. Нельзя доверять tenant id из произвольного payload; его получают из проверенной identity. Административный IgnoreQueryFilters изолируют, тестируют обходы и учитывают, что pooled DbContext требует особой передачи tenant state.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000211"),
                column: "text",
                value: "Нужны глобальные фильтры, правила уникальности только среди активных строк, каскадная семантика, аудит и политика физической очистки. IgnoreQueryFilters может случайно вернуть удалённые данные, а навигации — дать неожиданный результат. Для некоторых данных temporal/audit table или отдельный статус жизненного цикла честнее.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000222"),
                column: "text",
                value: "Interceptor полезен для cross-cutting concerns: telemetry, command tagging, connection hooks или построение outbox на SaveChanges. Бизнес-решения и изменения агрегатов в нём становятся неявными и зависят от порядка вызовов. Interceptor должен быть детерминированным, быстрым и иметь тесты на retry и транзакции.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000233"),
                column: "text",
                value: "Значения всегда параметризуют через FromSqlInterpolated или параметры провайдера. Имена таблиц, колонок и направление сортировки параметризовать нельзя, поэтому их выбирают только из whitelist, а не из пользовательской строки. Нужно понимать composability запроса и не полагаться на escaping как на полноценную защиту.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000244"),
                column: "text",
                value: "Он не проверяет SQL translation, ограничения, транзакции, collation, null semantics и поведение конкретного провайдера. Для unit-тестов домена база не нужна; для persistence-тестов используют реальный engine в контейнере или SQLite только если его различия допустимы. Критичные запросы тестируют на production-провайдере.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000251"),
                column: "text",
                value: "Применяют expand-contract: сначала добавляют совместимую nullable/default колонку, разворачивают код с dual read/write или backfill, затем переключают чтение и только в следующем релизе удаляют старую. Долгие index build и table rewrite планируют отдельно. Миграции не должны предполагать мгновенное обновление всех экземпляров.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000262"),
                column: "text",
                value: "Несколько экземпляров могут одновременно менять схему, блокировать startup и получить разные результаты при частичной ошибке. Production-миграции лучше выполнять отдельным контролируемым job с правами DDL, backup и наблюдаемостью. Автомиграция удобна для локального MVP, но это осознанное ограничение окружения.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000273"),
                column: "text",
                value: "Начинают с сгенерированного SQL и плана базы: порядок фильтров в LINQ сам по себе не задаёт порядок индекса. Проектируют индекс по equality/range predicates, sort и selectivity, при необходимости include/partial возможности провайдера. Затем измеряют чтения и latency на репрезентативных данных.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000284"),
                column: "text",
                value: "JOIN двух sibling-коллекций создаёт произведение их строк: 10 элементов одной и 10 другой дают 100 строк на корень, хотя объектов меньше. Это увеличивает сеть и materialization. Помогают проекция, split query, отдельные запросы или изменение read model.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000291"),
                column: "text",
                value: "Batch уменьшает roundtrips, но слишком большой пакет увеличивает SQL, параметры, locks, memory и время транзакции. Провайдер имеет собственные пределы и heuristics. Измеряют throughput и p95 на реальной сети; для очень больших загрузок используют bulk/native copy, staging table или set-based команды.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000302"),
                column: "text",
                value: "Современный EF обычно выбрасывает исключение вне верхней client projection, чтобы не загрузить таблицу незаметно. Нужно переписать выражение в поддерживаемую форму, вынести вычисление после узкой материализации или добавить mapping database function. AsEnumerable ставят только после явного ограничения данных.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000313"),
                column: "text",
                value: "Проецируют сразу в DTO только нужные поля, применяют фильтр и пагинацию до materialization, используют AsNoTracking и избегают Include, если Select уже выражает форму. Это уменьшает данные, ChangeTracker и coupling. Сгенерированный SQL и число roundtrips всё равно проверяют.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000324"),
                column: "text",
                value: "Если read-only результат содержит повторные ссылки на одну сущность, обычный no-tracking создаст несколько экземпляров. Identity resolution использует временный tracker только для материализации и возвращает единые ссылки без дальнейшего tracking. Это расходует дополнительные ресурсы, поэтому не нужно для плоской DTO-проекции.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000331"),
                column: "text",
                value: "Owned dependents внутри агрегата логично удалять вместе с root, и cascade отражает это правило. Между агрегатами database cascade может удалить данные без доменной проверки и создать длинные блокировки; чаще используют Restrict и отдельный use case. Поведение EF и самой БД нужно согласовать.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000342"),
                column: "text",
                value: "Domain events преобразуют в outbox rows и добавляют в тот же DbContext до SaveChanges, чтобы данные и намерение публикации зафиксировались одной транзакцией. Отдельный worker публикует их с retry и помечает обработанными. Получатель остаётся идемпотентным, потому что crash между publish и отметкой создаёт дубликат.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000353"),
                column: "text",
                value: "DbContext уже реализует Unit of Work и repository-подобный доступ. Универсальный CRUD-интерфейс часто скрывает возможности LINQ, допускает операции вне агрегата и разрастается спецификациями. Репозиторий оправдан как доменный контракт для aggregate roots; read side может использовать специализированные queries.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000364"),
                column: "text",
                value: "JSON удобен для атомарного вложенного документа с изменяемой схемой и редкими междокументными связями. Нужно проверить поддержку provider для query/update, индексы по путям и change tracking. Если поля участвуют в constraints, joins, частых частичных обновлениях или независимом жизненном цикле, нормализованная модель обычно прозрачнее.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000371"),
                column: "text",
                value: "Отдельный read DbContext направляют на replica только для tolerant-to-staleness сценариев. После команды пользователь может читать primary, передавать consistency token/временное окно или ждать позиции репликации. Routing нельзя скрывать полностью: use case должен знать требуемую консистентность.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000382"),
                column: "text",
                value: "Кэшируют DTO/read model, задают ключ с tenant и параметрами, ограниченный TTL и размер. Для важных обновлений используют invalidation/event version, но принимают возможность гонки. Кэш не должен возвращать tracked entities и не заменяет корректный источник истины.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000393"),
                column: "text",
                value: "Коррелируют trace запроса с EF command activity, фиксируют SQL, параметры, число roundtrips и время ожидания соединения. В базе анализируют actual plan, rows, buffers, locks и статистику; отдельно измеряют materialization и serialization. Оптимизацию начинают с доминирующего участка, а не с LINQ-косметики.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000404"),
                column: "text",
                value: "Если экран постоянно требует тяжёлых joins, денормализации, истории или иной формы данных, сложность и нагрузка сигнализируют о специализированной проекции. Read model обновляют синхронно в той же БД либо асинхронно с явной eventual consistency. Это компромисс между скоростью чтения, свежестью и операционной сложностью.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000011"),
                column: "text",
                value: "Direct маршрутизирует по точному routing key. Topic поддерживает шаблоны с * и #. Fanout отправляет сообщение во все связанные очереди, игнорируя ключ. Headers использует набор заголовков и применяется реже из-за большей сложности и стоимости сопоставления.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000022"),
                column: "text",
                value: "Сообщения публикуют как persistent в durable exchange/queue, используют publisher confirms, а consumer отправляет ack только после успешной обработки. При сбое сообщение доставляется повторно, поэтому consumer обязан быть идемпотентным, например хранить идентификаторы обработанных сообщений или использовать естественный уникальный ключ.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000033"),
                column: "text",
                value: "Dead-letter exchange получает сообщения, которые были rejected/nacked без requeue, истекли по TTL или вытеснены ограничением длины очереди. Он позволяет отделить проблемные сообщения, организовать retry с задержкой и сохранить данные для анализа вместо бесконечного цикла повторной доставки.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000044"),
                column: "text",
                value: "Prefetch ограничивает число неподтверждённых сообщений у consumer. Большое значение повышает throughput, но увеличивает память и может привести к неравномерному распределению. Малое улучшает fairness и время восстановления, но увеличивает влияние сетевых задержек. Значение подбирают по времени обработки и допустимому параллелизму.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000051"),
                column: "text",
                value: "Очередь сохраняет порядок публикации, но несколько consumers, повторная доставка, nack/requeue и разное время обработки меняют наблюдаемый порядок завершения. Если порядок критичен, используют один consumer или партиционирование по ключу и контролируют повторную обработку.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000062"),
                column: "text",
                value: "Ack сообщает broker, что consumer принял ответственность за доставку после успешной обработки. Confirm сообщает publisher, что broker принял ответственность за publish; для quorum queue — после репликации кворумом. Они защищают разные участки пути, а неопределённый исход при разрыве всё равно требует повторной отправки и идемпотентности.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000073"),
                column: "text",
                value: "Durable сохраняет определение очереди, persistent просит сохранить сообщение, но publisher не знает, успел ли broker безопасно принять его без confirms. На consumer-side ранний auto-ack также теряет сообщение при crash. Полная схема включает durable replicated queue, publisher confirms, manual ack после side effect и обработку неопределённых исходов.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000084"),
                column: "text",
                value: "Quorum queue нужна для репликации, предсказуемого leader election и высокой сохранности данных; она подтверждает publish после кворума. Цена — дополнительная latency, disk и network overhead, отсутствие transient/exclusive сценариев и ограничения для огромных backlog. Временные очереди, минимальная latency или очень длинные логи могут требовать classic queue или stream.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000091"),
                column: "text",
                value: "Без кворума очередь не может безопасно подтвердить новые записи и сохранить consistency, поэтому publish не получает успешный confirm либо блокируется/завершается ошибкой согласно клиенту и timeout. Система выбирает сохранность данных вместо availability. Producer должен ограниченно повторить неопределённые сообщения после восстановления и не считать timeout доказательством отсутствия записи.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000102"),
                column: "text",
                value: "Сообщение получает устойчивый MessageId или business operation id. В одной локальной транзакции consumer фиксирует id в inbox/processed table с unique constraint и применяет изменение; дубликат превращается в no-op. Ack отправляют после commit, а срок хранения ключей выбирают по максимальному окну повторной доставки.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000113"),
                column: "text",
                value: "Broker не может атомарно согласовать ack с произвольным side effect в другой системе. Crash после commit, но до ack, приводит к redelivery; confirm может потеряться после принятого publish. Практическая модель — at-least-once transport плюс идемпотентная обработка, deduplication и бизнес-операции с устойчивым ключом.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000124"),
                column: "text",
                value: "Prefetch ограничивает число unacked сообщений на consumer. Для CPU-bound обычно начинают около числа параллельных workers, для I/O-bound допускают больше, учитывая latency и connection limits. Большое значение повышает throughput, но увеличивает memory, время redelivery и несправедливость; настраивают по processing time, backlog и p95.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000131"),
                column: "text",
                value: "Сообщение немедленно возвращается в ту же очередь и снова попадает тому же или другому consumer, потребляя CPU и network без паузы. Лучше ограничивать попытки, направлять в delay/retry queue с TTL или delayed mechanism и после лимита — в DLQ. Причину и attempt count сохраняют в headers/metadata.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000142"),
                column: "text",
                value: "Consumer различает транзиентную и постоянную ошибку, ограничивает число повторов и переносит неисправимое сообщение в DLQ вместе с причиной и correlation metadata. Нужны alert, инструмент просмотра и контролируемый replay после исправления. Бесконечный requeue скрывает проблему и блокирует полезную нагрузку.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000153"),
                column: "text",
                value: "В classic queue сообщение за большим TTL в голове может задержать истёкшие сообщения позади него, а dead-lettering по умолчанию может иметь weaker guarantees. Создают отдельные retry buckets с фиксированными TTL, контролируют размер и используют quorum at-least-once dead lettering, если нужна сохранность. Для сложного расписания лучше внешний scheduler.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000164"),
                column: "text",
                value: "Publisher ставит mandatory и обрабатывает basic.return, одновременно используя confirms. Alternate exchange может собирать нерутируемые сообщения, но это другая бизнес-политика и требует мониторинга. Confirm означает принятие broker, а не обязательно попадание в ожидаемую очередь, поэтому оба сигнала различают.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000171"),
                column: "text",
                value: "Нужно понимать, что старые channels закрыты, in-flight confirms и deliveries имеют неопределённый исход, а topology recovery не восстанавливает внешние side effects. Producer повторяет неподтверждённое с idempotency id, consumer остаётся идемпотентным. Connection и channel lifecycle централизуют, recovery события и время недоступности наблюдают.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000182"),
                column: "text",
                value: "AMQP channel — логическая сессия с порядком frames и delivery tags; многие client operations не рассчитаны на конкурентную запись. Перемешивание publish frames или confirm state приводит к protocol errors и неверной корреляции. Используют channel per worker, ограниченный pool или сериализованный publisher согласно гарантиям клиента.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000193"),
                column: "text",
                value: "Publisher отслеживает monotonically increasing publish sequence number и хранит диапазоны outstanding сообщений. Ack/nack может иметь multiple=true и закрывать все sequence до указанного. Структура должна эффективно удалять диапазон, а при connection loss все оставшиеся считаются неопределёнными и могут быть повторены.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000204"),
                column: "text",
                value: "Stream хранит append-only log, поддерживает replay по offset, несколько независимых читателей и очень большой backlog. Это подходит event log, fan-out и аналитической обработке. Очередь лучше для распределения задач, удаления после ack и сложной routing-семантики; operational модель и client API различаются.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000211"),
                column: "text",
                value: "Глобальный порядок теряется, но сохраняется внутри partition. Routing key должен стабильно отправлять связанные события, например одного aggregate id, в одну partition. Число partition определяет параллелизм и стоимость, а consumer group распределяет их между экземплярами; hotspot key всё ещё ограничивает throughput.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000222"),
                column: "text",
                value: "Контракт должен быть backward/forward совместим: добавляют optional поля с defaults, не меняют смысл существующих и версионируют breaking event type. Consumer применяет tolerant reader и тестируется на старых payload. Envelope содержит event type, schema version, id, causation/correlation и occurred time, но не должен скрывать бизнес-семантику.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000233"),
                column: "text",
                value: "Domain event отражает внутреннюю модель и может меняться вместе с ней. Integration event — стабильный внешний контракт, минимально раскрывающий данные и часто строящийся после commit. Разделение уменьшает coupling, позволяет обогащать и версионировать сообщение, не публикуя внутренние классы агрегата.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000244"),
                column: "text",
                value: "Outbox атомарно сохраняет бизнес-изменение и сообщение в одной БД. Dispatcher публикует его и только после confirm отмечает отправленным; crash между этими действиями создаёт повторный publish. Поэтому outbox предотвращает потерю намерения, confirms подтверждают broker, а idempotent consumer закрывает дубликаты.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000251"),
                column: "text",
                value: "События маршрутизируют по aggregate id в фиксированную partition/queue и обрабатывают её последовательно одним активным consumer, а разные ключи — параллельно. Альтернатива — version check и буферизация out-of-order, что сложнее. Один глобальный consumer сохраняет порядок, но уничтожает масштабирование.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000262"),
                column: "text",
                value: "Нужны rates publish/deliver/ack, число unacked, age старейшего сообщения, redelivery rate, consumer utilization, disk/memory alarms, confirm latency и connection/channel churn. Depth без входного и выходного rate не показывает, растёт ли backlog. Метрики связывают с SLO времени обработки, а не только с размером очереди.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000273"),
                column: "text",
                value: "Сравнивают arrival rate и sustainable processing rate, возраст старейшего сообщения и прогноз drain time. Плановый burst с уменьшающимся age может быть нормальным, постоянный рост age при насыщенных consumers — деградация. Также проверяют poison loop, downstream latency, prefetch и resource alarms broker.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000284"),
                column: "text",
                value: "Broker применяет flow control и блокирует publishing connections, чтобы защитить процесс и данные; consumers обычно могут продолжать дренировать очереди. Producer обязан иметь timeout, bounded buffer и telemetry, иначе блокировка распространится на приложение. Устраняют первопричину capacity/backlog, а не просто повышают порог.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000291"),
                column: "text",
                value: "Создание connection дорого, создаёт churn, нагрузку и может само усугубить отказ. Долгоживущие connections переиспользуют, а health проверяет состояние лёгким способом и различает readiness от liveness. Недоступность broker не всегда должна рестартовать процесс; это зависит от способности сервиса буферизовать или деградировать.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000302"),
                column: "text",
                value: "Сначала прекращают принимать новые deliveries или отменяют consumer, затем ждут завершения in-flight в пределах timeout и отправляют ack/nack. Channel закрывают после handlers, connection — последним. Если timeout истёк, незавершённые unacked доставки вернутся в очередь, поэтому обработка обязана быть идемпотентной.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000313"),
                column: "text",
                value: "Большие сообщения увеличивают memory, disk I/O, replication traffic, latency и время redelivery. В broker и client задают разумный limit; крупный blob кладут в object storage, а в сообщение — ссылку, checksum и metadata с контролем lifetime и доступа. Компрессия помогает сети, но добавляет CPU и риск decompression bomb.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000324"),
                column: "text",
                value: "Одно событие должно выражать атомарный бизнес-факт, но transport batch может объединять публикацию или обработку ради throughput. Огромный business batch усложняет retry: одна плохая запись повторяет всё. Если пакет неизбежен, нужна стратегия частичного результата, idempotency каждого элемента и ограничения размера.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000331"),
                column: "text",
                value: "Unique inbox key в БД остаётся источником истины, потому что broker redelivery и network partition допускают конкуренцию. Операцию выполняют в транзакции после успешной вставки ключа либо используют version/unique business constraint. Распределённый lock редко заменяет идемпотентность и добавляет собственные failure modes.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000342"),
                column: "text",
                value: "Он даёт активного consumer с автоматическим failover и удобен, когда очередь должна обрабатываться последовательно. Цена — ограниченный throughput и пауза при переключении; порядок всё равно зависит от requeue и publisher routing. Для масштабирования по ключу лучше несколько partition с SAC на каждой.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000353"),
                column: "text",
                value: "Приоритет позволяет срочным сообщениям обгонять обычные, но слишком много уровней увеличивает внутренние структуры и CPU. Постоянный поток высокого приоритета может вызвать starvation низкого. Часто прозрачнее иметь несколько очередей с отдельными capacity/SLO и управляемым распределением consumers.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000364"),
                column: "text",
                value: "Каждая очередь хранит состояние, метаданные, процессы и метрики; quorum queue добавляет replicas и consensus overhead. Огромная topology увеличивает recovery time и операционную сложность. Разделение делают по независимому backlog, SLA, retention или ownership, а не по каждому типу сообщения автоматически.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000371"),
                column: "text",
                value: "Команда выражает намерение конкретному владельцу и может быть отклонена; событие сообщает свершившийся факт и не адресует единственного исполнителя. Название, routing, retry и ожидания ответа различаются. Маскировка команды под событие создаёт скрытую оркестрацию и неясную ответственность.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000382"),
                column: "text",
                value: "Если вызывающий блокируется в ожидании немедленного ответа, broker добавляет latency, correlation state, timeout и failure modes, но не даёт преимуществ асинхронности. Для короткого запроса часто лучше HTTP/gRPC. Messaging request/reply оправдан при buffering, изоляции или долгом workflow, причём timeout не отменяет уже принятую работу.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000393"),
                column: "text",
                value: "Интеграционные тесты должны убивать consumer после commit до ack, разрывать connection до confirm, давать duplicate/out-of-order payload, заполнять DLQ и имитировать недоступный downstream. Проверяют инварианты и отсутствие потери, а не только happy path. Для quorum queue отдельно тестируют потерю leader и кворума.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000404"),
                column: "text",
                value: "Минимально: message id, type/version, occurred time, correlation id, causation id и trace context; tenant и actor добавляют только при необходимости и с учётом безопасности. Processing span связывают с publish span, но consumer создаёт новый span link/parent согласно семантике. Payload и персональные данные не логируют без контроля.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000011"),
                column: "text",
                value: "MVCC хранит несколько версий строк, позволяя читателям и писателям меньше блокировать друг друга. UPDATE создаёт новую версию, а старая становится dead tuple после завершения видимых транзакций. VACUUM освобождает место для повторного использования и предотвращает переполнение transaction ID; autovacuum автоматизирует процесс.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000022"),
                column: "text",
                value: "B-tree — универсальный выбор для равенства, диапазонов и сортировки. Hash оптимизирован для равенства, но обычно не даёт преимуществ над B-tree. GIN эффективен для составных значений, массивов, JSONB и полнотекстового поиска. GiST поддерживает расширяемые стратегии, геометрию, диапазоны и nearest-neighbor поиск.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000033"),
                column: "text",
                value: "Сравнивают estimated и actual rows, время узлов, число loops, способ доступа и операции сортировки/хеширования. Большие расхождения строк указывают на устаревшую статистику или коррелированные данные. Seq Scan не всегда плох: он разумен для маленькой таблицы или выборки большой доли строк.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000044"),
                column: "text",
                value: "PostgreSQL предоставляет Read Committed, Repeatable Read и Serializable; Read Uncommitted ведёт себя как Read Committed. Serializable нужен, когда результат параллельных транзакций должен быть эквивалентен последовательному выполнению. Он может завершить транзакцию serialization failure, поэтому приложение обязано поддерживать retry.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000051"),
                column: "text",
                value: "Последовательное чтение может быть дешевле для маленькой таблицы или низкой селективности. Причинами также бывают несовместимое выражение или преобразование типа, устаревшая статистика, ведущий wildcard, неподходящий порядок составного индекса и функции без соответствующего expression index.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000062"),
                column: "text",
                value: "Долгая transaction snapshot удерживает xmin, поэтому версии строк, потенциально видимые ей, нельзя удалить. Dead tuples накапливаются, таблицы и индексы раздуваются, планы и I/O ухудшаются, а wraparound risk растёт. Ищут age транзакций и idle in transaction sessions, ограничивают timeout и сокращают бизнес-операции внутри транзакции.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000073"),
                column: "text",
                value: "Обычный VACUUM помечает место reusable и обновляет visibility map без возврата файла ОС; он допускает параллельную работу. VACUUM FULL переписывает таблицу, возвращает место, но берёт сильную блокировку. Autovacuum выполняет регулярную очистку/analyze и anti-wraparound; его чаще настраивают, а не отключают.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000084"),
                column: "text",
                value: "HOT возможен, когда изменяемые колонки не участвуют в индексах и новая версия строки помещается на той же heap page; тогда не создаются новые записи во всех индексах. Пониженный fillfactor оставляет место для обновлений, уменьшая index bloat, но увеличивает размер таблицы. Эффект проверяют по статистике HOT updates и характеру нагрузки.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000091"),
                column: "text",
                value: "Индекс наиболее эффективен, когда ведущие колонки ограничены equality, затем идёт range/sort; правило не сводится к selectivity одного поля. Он может обслужить left prefix и порядок ORDER BY. Проектирование зависит от реальных predicates, частоты запросов и write cost, а не от создания всех комбинаций.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000102"),
                column: "text",
                value: "INCLUDE хранит payload-колонки, не участвующие в поисковом ключе, и может позволить index-only scan без расширения семантики ключа. Цена — больший индекс, больше WAL и стоимость updates. Реальная выгода зависит от visibility map: если heap pages не all-visible, чтение heap всё равно потребуется.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000113"),
                column: "text",
                value: "MVCC-видимость обычно хранится в heap, поэтому executor проверяет visibility map. Если страницы недавно изменялись и не помечены all-visible после vacuum, приходится читать heap. Также план может выбрать другой путь из-за cost, низкой селективности, размера индекса или устаревшей статистики.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000124"),
                column: "text",
                value: "Partial index полезен для небольшого часто запрашиваемого подмножества, например active rows, уменьшая размер и write cost. Planner использует его только если может доказать, что WHERE запроса подразумевает predicate индекса. Параметризованное или иначе сформулированное условие может помешать доказательству.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000131"),
                column: "text",
                value: "Они индексируют результат выражения, например lower(email), чтобы запрос с тем же выражением использовал B-tree. Выражение должно быть immutable относительно строки; иначе индекс перестанет соответствовать данным. Цена вычисляется при insert/update, а синтаксис запроса должен совпадать распознаваемым образом.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000142"),
                column: "text",
                value: "Обычная статистика считает колонки в основном независимо, поэтому коррелированные predicates дают ошибочную cardinality. CREATE STATISTICS может собирать dependencies, ndistinct или MCV для группы колонок. Это улучшает выбор join/order, но не заменяет актуальный ANALYZE и не собирает статистику между разными таблицами.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000153"),
                column: "text",
                value: "Nested loop хорош для малого outer input и индексного поиска во inner. Hash join эффективен для больших equality joins при достаточном work_mem; spill замедляет его. Merge join использует отсортированные входы и полезен для больших упорядочиваемых наборов или range-подобных условий. Решение зависит от оценок cardinality.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000164"),
                column: "text",
                value: "work_mem применяется на каждый sort/hash node и потенциально на каждого parallel worker, поэтому один запрос может потребить его многократно, а множество сессий — исчерпать RAM. Малое значение вызывает temp spill. Настраивают глобально умеренно, а для известных аналитических операций — локально в транзакции после измерения.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000171"),
                column: "text",
                value: "Это число строк, прочитанных узлом, но отброшенных его filter; большое значение может указывать на плохой access path или отсутствующий подходящий индекс. Однако для маленькой таблицы sequential scan может быть дешевле. Смотрят actual loops, buffers, время и отношение estimated к actual rows в контексте всего плана.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000182"),
                column: "text",
                value: "ANALYZE реально выполняет statement, поэтому UPDATE/DELETE/INSERT изменит данные и может долго блокировать. Его запускают в BEGIN с последующим ROLLBACK, на безопасной копии или используют EXPLAIN без ANALYZE. Даже SELECT с ANALYZE создаёт нагрузку и может повлиять на production latency.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000193"),
                column: "text",
                value: "Для распределения с сильным skew оптимальный plan зависит от значения параметра. После нескольких запусков PostgreSQL может выбрать generic plan, средний по стоимости, но плохой для редких значений. Проверяют custom/generic behavior, статистику и при необходимости меняют форму запроса, plan_cache_mode или разделяют сценарии.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000204"),
                column: "text",
                value: "Ожидающие locks образуют очередь, и одна длинная транзакция может блокировать множество запросов; новые запросы иногда встают за уже ожидающим сильным lock. Сначала находят root blocker, его операцию и возможность безопасного rollback. Kill освобождает locks, но откат может быть долгим и повториться без устранения причины.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000211"),
                column: "text",
                value: "Deadlock — цикл ожиданий, который PostgreSQL обнаруживает после deadlock_timeout и прерывает одну транзакцию; обычное ожидание имеет потенциального освобождающего владельца. Анализируют server log, pg_locks, pg_stat_activity и порядок захвата ресурсов. Исправляют единым порядком locks, короткими транзакциями и точными predicates.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000222"),
                column: "text",
                value: "Он блокирует выбранные строки от конкурентного изменения и подходит для read-modify-write. Для нескольких workers применяют FOR UPDATE SKIP LOCKED, понимая, что это даёт неполный снимок, но хорошо распределяет jobs. Оптимистичная версия/conditional update может быть лучше при редких конфликтах.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000233"),
                column: "text",
                value: "PostgreSQL использует Serializable Snapshot Isolation и отслеживает опасные зависимости, не превращая все чтения в blocking locks. При возможной аномалии одна транзакция завершается serialization_failure. Клиент должен повторить всю транзакцию с новым snapshot, ограниченно и только если её внешние side effects безопасны.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000244"),
                column: "text",
                value: "Каждый statement получает новый snapshot на начало statement, поэтому committed изменения между запросами становятся видимыми. Это нормальная гарантия уровня, а не ошибка MVCC. Если бизнес-инвариант требует стабильного snapshot, используют Repeatable Read/Serializable или формулируют операцию одним atomic statement.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000251"),
                column: "text",
                value: "Они дают application-defined ключ и не привязаны автоматически к строке, поэтому все участники обязаны следовать одному протоколу. Transaction-level locks освобождаются при завершении транзакции и обычно безопаснее session-level. Нужно избегать коллизий ключей, держать lock коротко и не считать его заменой database constraints.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000262"),
                column: "text",
                value: "INSERT ... ON CONFLICT атомарно использует unique constraint для insert/update и устраняет check-then-act race. Но update expression всё равно должен сохранять бизнес-инвариант, а несколько связанных строк требуют транзакции или другого constraint. Неверный conflict target и side effects вне БД остаются проблемой.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000273"),
                column: "text",
                value: "Ключ должен поддерживать pruning основных запросов, lifecycle данных и равномерное распределение. Временной range удобен для retention, hash — для распределения, list — для ограниченных доменов. Слишком много partition увеличивает planning/metadata overhead, а unique constraint обычно должен включать partition key.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000284"),
                column: "text",
                value: "Она помогает, когда pruning исключает большую часть данных или облегчает maintenance, но запросы по другому ключу могут читать все partitions. Индексы всё равно нужны, joins и planning усложняются, skew создаёт hot partition. Сначала подтверждают проблему размера, retention или contention.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000291"),
                column: "text",
                value: "Если таблица partitioned по времени, detach/drop старой partition почти мгновенно освобождает логический объём и избегает миллионов row deletes/WAL. Без partitioning удаляют небольшими batches с паузами и vacuum, контролируя replicas и locks. Большая одиночная DELETE создаёт bloat и длительную транзакцию.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000302"),
                column: "text",
                value: "Physical streaming передаёт WAL на уровне кластера, хорошо подходит HA и read replicas той же major-совместимой системы. Logical публикует изменения выбранных таблиц и допускает иной layout/частичные наборы и upgrade-сценарии, но имеет ограничения DDL, sequences и конфликтов. Обе обычно асинхронны и могут отставать.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000313"),
                column: "text",
                value: "RPO — допустимая потеря данных; async replica имеет ненулевой RPO, synchronous commit может приблизить его к нулю ценой latency/availability. RTO — время обнаружения, promotion, routing и восстановления приложения. Репликация без протестированного failover, fencing и backup не даёт полного HA.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000324"),
                column: "text",
                value: "Успешно записанный архив может быть неполным, несовместимым, повреждённым или не включать нужный WAL для PITR. Регулярный автоматизированный restore проверяет целостность, время восстановления и инструкции. Реплика не заменяет backup, потому что логическое удаление или corruption реплицируется.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000331"),
                column: "text",
                value: "Изменения сначала записываются в WAL для durability и recovery, а затем страницы данных сбрасываются отдельно. Большие updates, indexes и full-page images увеличивают объём WAL, I/O и lag replicas. Измеряют WAL generation, checkpoint behavior и network; отключать durability ради скорости можно только при явном принятии потери.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000342"),
                column: "text",
                value: "Checkpoint вынуждает сбрасывать множество dirty pages и после него первые изменения страниц могут генерировать full-page images. Если max_wal_size мал или нагрузка велика, I/O становится bursty. Настраивают checkpoint_timeout, max_wal_size и completion_target, наблюдая write latency и объём WAL.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000353"),
                column: "text",
                value: "Каждое backend connection — процесс с памятью и потенциальным work_mem, поэтому тысячи idle connections дороги. Pooler ограничивает активные backend и мультиплексирует клиентов; transaction pooling несовместим с session state, temp tables и некоторыми prepared statements. Размер пула связывают с CPU и пропускной способностью, а не числом HTTP-запросов.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000364"),
                column: "text",
                value: "Клиент получает разные backend между транзакциями, поэтому session-level SET, advisory locks, temp tables, LISTEN и некоторые prepared statement assumptions ломаются. Приложение должно задавать нужное состояние transaction-local или отказаться от этих функций. Это цена высокой эффективности мультиплексирования.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000371"),
                column: "text",
                value: "BRIN хранит summary диапазонов страниц и очень мал, поэтому хорош для огромных append-mostly таблиц, где значение физически коррелирует с порядком, например timestamp. Он возвращает lossy ranges и хуже для случайно распределённых точечных поисков. pages_per_range балансирует размер и точность.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000382"),
                column: "text",
                value: "GIN инвертирует элементы и обычно быстрее ищет containment/full-text, но дороже обновляется и может иметь pending list. GiST хранит обобщённое дерево, поддерживает distance/nearest-neighbor и разные операторные классы, часто с lossy recheck. Выбор определяется операторами, update rate и измерением.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000393"),
                column: "text",
                value: "Если conversion требует rewrite, PostgreSQL переписывает все строки под сильной блокировкой и генерирует WAL. Для большой таблицы применяют expand-contract: новую колонку, backfill batches, dual write, проверку и переключение. Некоторые бинарно совместимые изменения metadata-only, но это проверяют для конкретной версии.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000404"),
                column: "text",
                value: "Сравнивают старый и новый plan, estimated/actual rows, статистику и распределение значений; проверяют ANALYZE, bloat, новые параметры и generic plans. Увеличивают statistics target для skewed колонок или создают extended statistics, затем исправляют запрос/индекс. Принудительный hint-подход не заменяет корректную модель cost.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000011"),
                column: "text",
                value: "Агрегат — граница строгой согласованности и транзакции. Внешний код обращается только к Aggregate Root, который защищает инварианты. Другие агрегаты связываются по идентификатору, а не через большой объектный граф; eventual consistency между агрегатами реализуют доменными событиями.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000022"),
                column: "text",
                value: "CQRS полезен, когда модели чтения и изменения заметно различаются, нужны независимое масштабирование, сложные бизнес-команды или разные требования к консистентности. Для простого CRUD разделение добавляет типы, обработчики и инфраструктуру без достаточной выгоды. CQRS не требует автоматически отдельных баз или event sourcing.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000033"),
                column: "text",
                value: "Выбор зависит от организационных границ, независимого масштабирования, скорости изменений и операционной зрелости. Модульный монолит часто является лучшей стартовой точкой: сохраняет простые транзакции и деплой, но дисциплинирует границы. Микросервисы оправданы, когда независимость команд и частей системы окупает распределённую сложность.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000044"),
                column: "text",
                value: "Изменение бизнес-данных и запись сообщения outbox выполняются в одной локальной транзакции. Отдельный publisher читает outbox и доставляет сообщения брокеру с повторами. Это устраняет dual-write между БД и брокером, но потребители всё равно должны быть идемпотентными из-за возможных дубликатов.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000051"),
                column: "text",
                value: "Операция должна давать один бизнес-результат при повторном запросе. Используют idempotency key, уникальное ограничение и атомарную запись результата, сохраняя ответ для повторного возврата. Важно определить срок хранения ключей и отличать повтор того же запроса от конфликта с другим содержимым.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000062"),
                column: "text",
                value: "Bounded context — граница модели и языка, где термины имеют однозначный смысл; это логическая граница DDD. Микросервис — deployment и operational boundary. Один сервис может временно содержать несколько контекстов, а один контекст иногда разворачивается несколькими компонентами; связь выбирают по ownership, coupling и независимости изменений.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000073"),
                column: "text",
                value: "Invariant — правило, которое должно быть истинно после каждой успешной команды. Aggregate root сериализует изменения внутри своей границы и проверяет правила в одной транзакции. Если граница включает всё связанное, возникает огромный lock/graph; между агрегатами применяют ссылки по id и eventual consistency с компенсацией.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000084"),
                column: "text",
                value: "Когда бизнес допускает промежуточное состояние и имеет ясное окно, статус и способ разрешения конфликта: например заказ принят, резерв ожидается. Пользователь должен видеть pending/failed, процесс — быть идемпотентным и наблюдаемым. Если нарушение правила даже на мгновение недопустимо, данные принадлежат одной strong-consistency границе.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000091"),
                column: "text",
                value: "Saga разбивает процесс на локальные транзакции и компенсирующие действия. Orchestrator явно хранит состояние и посылает команды, упрощая наблюдаемость сложного workflow; choreography связывает сервисы событиями и лучше для простого процесса, но легко создаёт скрытый граф. Компенсация — новая бизнес-операция, а не магический rollback.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000102"),
                column: "text",
                value: "Она связывает availability и latency участников, усложняет recovery и часто не поддерживается внешними системами. Outbox, idempotency и saga дают локальную атомарность и явное промежуточное состояние. Distributed transaction допустима в ограниченной инфраструктуре с измеренной ценой, но не должна скрывать отсутствие бизнес-политики отказа.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000113"),
                column: "text",
                value: "Если изменение внутренней модели одного постоянно заставляет менять другой, общий контракт содержит чужие сущности или low-level слой диктует use case, зависимость направлена не по policy. Стабильные бизнес-правила должны зависеть от абстракций, а детали реализовывать их. Метрики coupling помогают, но решающим остаётся ownership причин изменения.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000124"),
                column: "text",
                value: "Она направляет зависимости к policy, изолирует use cases от UI, БД и frameworks и облегчает тестирование заменяемых деталей. Она не создаёт правильную доменную модель, производительность или распределённую надёжность автоматически. Чрезмерное число pass-through слоёв и generic abstractions может увеличить ceremony без реальной независимости.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000131"),
                column: "text",
                value: "Write-side repository восстанавливает aggregate root для выполнения поведения и скрывает persistence. Read use case не обязан материализовать агрегат: проекция DTO может обращаться к оптимизированному query service/read model. Смешивание IQueryable в доменный контракт выдаёт детали хранения и позволяет обходить границы агрегата.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000142"),
                column: "text",
                value: "Domain event фиксирует факт внутри модели; handlers могут обновить локальное состояние до commit или подготовить outbox. Порядок, повторный вызов и ошибка должны иметь определённую семантику. Для внешних подписчиков событие преобразуют в integration event и публикуют после атомарной записи, а не отправляют из агрегата.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000153"),
                column: "text",
                value: "Сначала проверяют, действительно ли правило должно быть атомарным. Если да, возможно граница агрегата неверна или нужна database constraint/одна транзакция application service. Если допускается задержка, команда меняет один агрегат и запускает process manager; конфликты и компенсации становятся частью модели.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000164"),
                column: "text",
                value: "Единый язык связывает разговор с экспертом, модель, команды, события и код, уменьшая перевод и неоднозначность. Один термин не должен означать разные вещи внутри context, а разные понятия не маскируются общим DTO. Изменение языка — сигнал уточнить модель, а не просто переименовать классы.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000171"),
                column: "text",
                value: "Если entities — набор setters, а правила размазаны по services, инварианты легко обходятся и модель анемична. Rich model полезна для сложного поведения и жизненного цикла. В простом CRUD bounded context сложность домена мала, и попытка искусственно добавить методы и aggregates только увеличит ceremony.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000182"),
                column: "text",
                value: "Когда доменные границы ещё уточняются, команда невелика и независимый deployment не окупает distributed cost. Модули получают private data/schema ownership, явные contracts и dependency tests, оставаясь в одном процессе и deployment. Это не слоистый монолит: границы должны быть реальными, чтобы при необходимости выделиться.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000193"),
                column: "text",
                value: "Независимый ownership и cadence, отдельное масштабирование, security/isolation, иной availability requirement или стабильная bounded-context граница. Размер кода сам по себе слабый аргумент. До выделения оценивают distributed transactions, latency, observability, on-call и стоимость versioned contracts.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000204"),
                column: "text",
                value: "Компоненты связаны не только ссылками, но и общим значением, порядком, алгоритмом, временем или идентичностью. Чем сильнее и дальше connascence, тем дороже изменение. Сильные формы стараются держать локально, а через удалённые границы оставлять явные стабильные контракты и минимальные временные предположения.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000211"),
                column: "text",
                value: "Контракт делают ориентированным на capability, добавляют optional поля, сохраняют семантику и применяют tolerant reader. Breaking change получает новую версию с периодом coexistence и telemetry использования старой. Внутреннюю entity не сериализуют напрямую, иначе каждое изменение модели становится внешним.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000222"),
                column: "text",
                value: "Все retries одного намерения должны нести один ключ, иначе сервер не отличит повтор от новой операции. Сервер атомарно сохраняет ключ, fingerprint запроса и результат в ограниченном scope пользователя/операции. Повтор с тем же ключом и другим payload отклоняется, а retention соответствует окну повторов.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000233"),
                column: "text",
                value: "Timeout ограничивает одну попытку, retry повторяет вероятно транзиентный сбой, circuit breaker временно прекращает вызовы к явно нездоровой зависимости. Вместе они защищают ресурсы, но неверные настройки умножают нагрузку. Нужны общий deadline, jitter, ограничение конкуренции и ясная fallback-семантика.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000244"),
                column: "text",
                value: "Bulkhead разделяет ограниченные ресурсы, чтобы отказ одного workload/tenant/dependency не исчерпал все threads, connections или queue capacity. Это могут быть отдельные pools, semaphores, queues или deployments. Границы выбирают по failure domain и SLO; слишком мелкое деление снижает utilization.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000251"),
                column: "text",
                value: "Когда downstream насыщен, upstream должен замедлиться, получить явный reject/429 или сбросить нагрузку по политике, а не бесконечно накапливать memory и queues. Bounded buffers, concurrency limits и deadlines задают пределы на каждом участке. Retry учитывает сигнал и не превращает перегрузку в storm.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000262"),
                column: "text",
                value: "SLI — измеряемая доля хороших событий, например запросы быстрее 300 мс без 5xx; SLO — целевая доля за окно. Error budget — допустимый остаток неуспеха, который связывает reliability с темпом изменений. Метрика должна отражать пользовательский outcome и исключать только заранее определённые случаи.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000273"),
                column: "text",
                value: "Среднее скрывает tail, который определяет опыт многих пользователей и усиливается при fan-out: максимум нескольких downstream растёт. Смотрят p50/p95/p99, распределение, saturation и ошибки по endpoint/tenant. Оптимизация tail часто требует limits, кэша, устранения очередей и медленных зависимостей.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000284"),
                column: "text",
                value: "Trace связывает causality через сервисы и очереди, показывает critical path и fan-out. Sampling может пропустить редкие ошибки, clock/async boundaries и неверная propagation искажают картину, а наличие span не доказывает причину. Traces дополняют metrics, logs и профили, а не заменяют их.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000291"),
                column: "text",
                value: "Модель выбирают по риску и масштабу: shared tables с tenant key, schema-per-tenant или database-per-tenant. Нужны защита от cross-tenant query, квоты, encryption/audit и план noisy neighbor. Часто применяют tiers: общая инфраструктура для большинства и выделенная для регулируемых клиентов.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000302"),
                column: "text",
                value: "Приложение сначала читает кэш, при miss — источник и заполняет кэш; это просто и устойчиво к падению кэша. Между write и invalidation возможны stale reads, stampede и race с поздним заполнением. TTL, versioned keys, single-flight и событие invalidation уменьшают риск, но consistency остаётся явной.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000313"),
                column: "text",
                value: "Используют per-key request coalescing/single-flight, jittered TTL, background refresh и stale-while-revalidate. Для критичных ключей можно краткий distributed lock, но нужен timeout и fallback. Предварительный прогрев помогает известным hot keys; бесконечный retry к источнику при miss усугубляет отказ.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000324"),
                column: "text",
                value: "Когда история изменений является бизнес-ценностью, нужны temporal queries/audit, сложные процессы или восстановление новых projections. Цена — эволюция событий, replay, storage, eventual consistency и иной способ исправления ошибок. Если нужен только audit log, обычная модель плюс неизменяемый журнал часто проще.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000331"),
                column: "text",
                value: "Старые события остаются фактом и обычно не переписываются. Read path применяет upcasters или handlers нескольких версий, а новые writers выпускают новую совместимую версию. Миграция snapshot/projection отделена; каждый replay тестируют на полном историческом наборе и детерминированных dependencies.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000342"),
                column: "text",
                value: "Snapshot — производительная оптимизация, не источник истины. Его делают после измеренного числа событий или стоимости fold, версионируют вместе с моделью и умеют отбросить/rebuild. Слишком частые snapshots увеличивают writes, слишком редкие — recovery latency; важнее сохранить корректность replay.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000353"),
                column: "text",
                value: "ACL переводит модель внешней или legacy-системы в язык собственного bounded context и не даёт чужим понятиям проникнуть внутрь. Это adapters, translators и policy, а не только HTTP client wrapper. Цена дополнительного кода окупается, когда внешняя модель нестабильна, неоднозначна или имеет другой жизненный цикл.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000364"),
                column: "text",
                value: "Он фиксирует bounded contexts и отношения upstream/downstream: partnership, customer-supplier, conformist, ACL, published language и другие. Это делает зависимости и власть над контрактом явными. Карта должна отражать организационную реальность ownership, иначе желаемая схема быстро расходится с кодом.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000371"),
                column: "text",
                value: "Сервисы обходят API друг друга, связываются схемой и транзакциями, миграции требуют координации, а ownership данных размывается. Даже read-only доступ создаёт скрытый контракт. Переход возможен через выделение владельца таблиц, published views/events и постепенное прекращение прямых writes.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000382"),
                column: "text",
                value: "Трафик и capabilities переносят небольшими вертикальными срезами через facade/router, сохраняя работающий legacy для остального. Нужны ownership данных, синхронизация и критерий выключения старого пути. Простое дублирование функций без удаления legacy создаёт две постоянные системы и больший риск.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000393"),
                column: "text",
                value: "ADR кратко фиксирует контекст, решение, альтернативы, последствия и статус на момент выбора. Он объясняет почему, а не пересказывает реализацию, и обновляется новым ADR при пересмотре. Записывают значимые труднообратимые решения; документ хранится рядом с кодом и связан с измеримыми ограничениями.");

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000404"),
                column: "text",
                value: "Сравнивают не только лицензию, но и time-to-value, операционную зрелость, integration cost, lock-in, compliance, roadmap и стоимость владения/миграции. Строить стоит для дифференцирующей capability или уникальных требований; commodity чаще покупают. Решение включает exit strategy и proof of concept главного риска.");
        }
    }
}
