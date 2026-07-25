using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Quiz.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedMvpQuestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "questions",
                columns: new[] { "id", "ideal_answer", "text", "topic" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "IEnumerable<T> выполняет дальнейшие операции в памяти через LINQ to Objects. IQueryable<T> хранит expression tree, который провайдер переводит во внешний запрос, например SQL. IQueryable не стоит выпускать за границы слоя данных: это размывает ответственность, усложняет тестирование и позволяет вызывающему сформировать неэффективный запрос.", "В чём разница между IEnumerable<T> и IQueryable<T> и где проходит граница их безопасного использования?", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Компилятор преобразует async-метод в конечный автомат. При незавершённой await-операции управление возвращается вызывающему коду, а продолжение планируется после завершения Task. Для I/O поток обычно не блокируется и новый поток не требуется; пул потоков нужен преимущественно для CPU-bound работы.", "Как работает async/await в C# и почему async-метод не обязательно создаёт новый поток?", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Class подходит для объектов с идентичностью и изменяемым жизненным циклом. Record удобен для value-like моделей и DTO благодаря value equality и with-выражениям. Struct стоит применять для небольших неизменяемых значений, которые часто создаются и не требуют наследования; крупные структуры увеличивают стоимость копирования.", "Когда следует использовать record, class и struct?", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Span<T> представляет непрерывный участок памяти без дополнительных аллокаций и может ссылаться на массив, stackalloc или unmanaged memory. Это ref struct, поэтому он не может храниться в heap-объекте, использоваться через await или yield. Memory<T> можно хранить в объектах и передавать через async-границы, получая Span при синхронной обработке.", "Объясните назначение Span<T> и Memory<T>. Какие ограничения есть у Span<T>?", "CSharp" },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "Токен передают по всей цепочке вызовов и регулярно проверяют через ThrowIfCancellationRequested либо прокидывают в поддерживающие его API. Владелец CancellationTokenSource отвечает за отмену и освобождение ресурса. OperationCanceledException не следует превращать в обычную ошибку: она отражает ожидаемое завершение по запросу.", "Как правильно реализовать отмену длительной операции с помощью CancellationToken?", "CSharp" },
                    { new Guid("20000000-0000-0000-0000-000000000001"), "Tracking-запросы помещают сущности в ChangeTracker, поддерживают identity resolution и позволяют сохранить изменения через SaveChanges. AsNoTracking уменьшает расход памяти и CPU для read-only сценариев. Для сложных read-only графов возможен AsNoTrackingWithIdentityResolution, который устраняет дубликаты объектов без постоянного tracking.", "Чем отличаются tracking и no-tracking запросы в Entity Framework Core?", "EntityFramework" },
                    { new Guid("20000000-0000-0000-0000-000000000002"), "N+1 возникает, когда после одного запроса списка выполняется отдельный запрос для каждой записи. Её видно по логам SQL, профилировщику и метрикам количества запросов. Обычно помогают проекция Select, осознанный Include, пакетная загрузка и отключение неуместной lazy loading.", "Что такое проблема N+1 и как её обнаружить и устранить в EF Core?", "EntityFramework" },
                    { new Guid("20000000-0000-0000-0000-000000000003"), "Include нужен, когда требуется материализовать и изменять граф доменных сущностей. Для чтения и API-ответов предпочтительнее Select в DTO: он выбирает только необходимые столбцы, уменьшает объём данных и часто формирует более простой SQL. Include не влияет на проекцию, если итоговый результат уже не является сущностью.", "Когда использовать Include, а когда проекцию Select?", "EntityFramework" },
                    { new Guid("20000000-0000-0000-0000-000000000004"), "В модель добавляют concurrency token, часто rowversion или явно управляемую версию. EF включает исходное значение токена в условие UPDATE/DELETE и при конфликте выбрасывает DbUpdateConcurrencyException. Приложение должно выбрать стратегию: повтор, слияние изменений или сообщение пользователю.", "Как организовать optimistic concurrency в EF Core?", "EntityFramework" },
                    { new Guid("20000000-0000-0000-0000-000000000005"), "DbContext представляет unit of work и обычно живёт в рамках одной операции. Он не является thread-safe: параллельные запросы и изменения одного экземпляра приводят к исключениям и повреждению состояния tracking. В долгоживущих процессах и Blazor Server применяют короткие scope, transient context или IDbContextFactory.", "Почему DbContext имеет scoped lifetime и какие риски возникают при его совместном использовании между потоками?", "EntityFramework" },
                    { new Guid("30000000-0000-0000-0000-000000000001"), "Direct маршрутизирует по точному routing key. Topic поддерживает шаблоны с * и #. Fanout отправляет сообщение во все связанные очереди, игнорируя ключ. Headers использует набор заголовков и применяется реже из-за большей сложности и стоимости сопоставления.", "Чем отличаются direct, topic, fanout и headers exchanges в RabbitMQ?", "RabbitMQ" },
                    { new Guid("30000000-0000-0000-0000-000000000002"), "Сообщения публикуют как persistent в durable exchange/queue, используют publisher confirms, а consumer отправляет ack только после успешной обработки. При сбое сообщение доставляется повторно, поэтому consumer обязан быть идемпотентным, например хранить идентификаторы обработанных сообщений или использовать естественный уникальный ключ.", "Как обеспечить at-least-once delivery и что должен делать consumer?", "RabbitMQ" },
                    { new Guid("30000000-0000-0000-0000-000000000003"), "Dead-letter exchange получает сообщения, которые были rejected/nacked без requeue, истекли по TTL или вытеснены ограничением длины очереди. Он позволяет отделить проблемные сообщения, организовать retry с задержкой и сохранить данные для анализа вместо бесконечного цикла повторной доставки.", "Что такое dead-letter exchange и для чего он нужен?", "RabbitMQ" },
                    { new Guid("30000000-0000-0000-0000-000000000004"), "Prefetch ограничивает число неподтверждённых сообщений у consumer. Большое значение повышает throughput, но увеличивает память и может привести к неравномерному распределению. Малое улучшает fairness и время восстановления, но увеличивает влияние сетевых задержек. Значение подбирают по времени обработки и допустимому параллелизму.", "Как prefetch влияет на производительность и справедливость распределения сообщений?", "RabbitMQ" },
                    { new Guid("30000000-0000-0000-0000-000000000005"), "Очередь сохраняет порядок публикации, но несколько consumers, повторная доставка, nack/requeue и разное время обработки меняют наблюдаемый порядок завершения. Если порядок критичен, используют один consumer или партиционирование по ключу и контролируют повторную обработку.", "Почему порядок сообщений в RabbitMQ нельзя считать абсолютной гарантией?", "RabbitMQ" },
                    { new Guid("40000000-0000-0000-0000-000000000001"), "MVCC хранит несколько версий строк, позволяя читателям и писателям меньше блокировать друг друга. UPDATE создаёт новую версию, а старая становится dead tuple после завершения видимых транзакций. VACUUM освобождает место для повторного использования и предотвращает переполнение transaction ID; autovacuum автоматизирует процесс.", "Как MVCC работает в PostgreSQL и зачем нужен VACUUM?", "PostgreSQL" },
                    { new Guid("40000000-0000-0000-0000-000000000002"), "B-tree — универсальный выбор для равенства, диапазонов и сортировки. Hash оптимизирован для равенства, но обычно не даёт преимуществ над B-tree. GIN эффективен для составных значений, массивов, JSONB и полнотекстового поиска. GiST поддерживает расширяемые стратегии, геометрию, диапазоны и nearest-neighbor поиск.", "В чём разница между B-tree, Hash, GIN и GiST индексами?", "PostgreSQL" },
                    { new Guid("40000000-0000-0000-0000-000000000003"), "Сравнивают estimated и actual rows, время узлов, число loops, способ доступа и операции сортировки/хеширования. Большие расхождения строк указывают на устаревшую статистику или коррелированные данные. Seq Scan не всегда плох: он разумен для маленькой таблицы или выборки большой доли строк.", "Как читать EXPLAIN ANALYZE и какие признаки указывают на проблему?", "PostgreSQL" },
                    { new Guid("40000000-0000-0000-0000-000000000004"), "PostgreSQL предоставляет Read Committed, Repeatable Read и Serializable; Read Uncommitted ведёт себя как Read Committed. Serializable нужен, когда результат параллельных транзакций должен быть эквивалентен последовательному выполнению. Он может завершить транзакцию serialization failure, поэтому приложение обязано поддерживать retry.", "Какие уровни изоляции транзакций поддерживает PostgreSQL и когда нужен Serializable?", "PostgreSQL" },
                    { new Guid("40000000-0000-0000-0000-000000000005"), "Последовательное чтение может быть дешевле для маленькой таблицы или низкой селективности. Причинами также бывают несовместимое выражение или преобразование типа, устаревшая статистика, ведущий wildcard, неподходящий порядок составного индекса и функции без соответствующего expression index.", "Почему индекс может не использоваться планировщиком PostgreSQL?", "PostgreSQL" },
                    { new Guid("50000000-0000-0000-0000-000000000001"), "Агрегат — граница строгой согласованности и транзакции. Внешний код обращается только к Aggregate Root, который защищает инварианты. Другие агрегаты связываются по идентификатору, а не через большой объектный граф; eventual consistency между агрегатами реализуют доменными событиями.", "Какие границы определяют агрегат в DDD?", "Architecture" },
                    { new Guid("50000000-0000-0000-0000-000000000002"), "CQRS полезен, когда модели чтения и изменения заметно различаются, нужны независимое масштабирование, сложные бизнес-команды или разные требования к консистентности. Для простого CRUD разделение добавляет типы, обработчики и инфраструктуру без достаточной выгоды. CQRS не требует автоматически отдельных баз или event sourcing.", "Когда CQRS полезен, а когда становится лишней сложностью?", "Architecture" },
                    { new Guid("50000000-0000-0000-0000-000000000003"), "Выбор зависит от организационных границ, независимого масштабирования, скорости изменений и операционной зрелости. Модульный монолит часто является лучшей стартовой точкой: сохраняет простые транзакции и деплой, но дисциплинирует границы. Микросервисы оправданы, когда независимость команд и частей системы окупает распределённую сложность.", "Как выбрать между монолитом, модульным монолитом и микросервисами?", "Architecture" },
                    { new Guid("50000000-0000-0000-0000-000000000004"), "Изменение бизнес-данных и запись сообщения outbox выполняются в одной локальной транзакции. Отдельный publisher читает outbox и доставляет сообщения брокеру с повторами. Это устраняет dual-write между БД и брокером, но потребители всё равно должны быть идемпотентными из-за возможных дубликатов.", "Что такое transactional outbox и какую проблему он решает?", "Architecture" },
                    { new Guid("50000000-0000-0000-0000-000000000005"), "Операция должна давать один бизнес-результат при повторном запросе. Используют idempotency key, уникальное ограничение и атомарную запись результата, сохраняя ответ для повторного возврата. Важно определить срок хранения ключей и отличать повтор того же запроса от конфликта с другим содержимым.", "Как проектировать идемпотентный API или обработчик команды?", "Architecture" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "questions",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000005"));
        }
    }
}
