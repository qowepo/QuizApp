using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quiz.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceDistractorsWithPlausibleAlternatives : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000012"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "IEnumerable<T> всегда строит expression tree, а IQueryable<T> всегда выполняет запрос в памяти." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000013"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "IQueryable<T> безопасно возвращать из любого слоя, потому что провайдер гарантирует оптимальный SQL." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000014"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "После вызова AsEnumerable оставшиеся LINQ-операции по-прежнему переводятся провайдером в SQL." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000021"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Каждый async-метод немедленно создаёт отдельный поток операционной системы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000023"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "await синхронно блокирует текущий поток до завершения Task, но освобождает SynchronizationContext." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000024"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Асинхронность ускоряет CPU-bound вычисление без параллелизма и дополнительных потоков." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000031"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Record следует использовать только для изменяемых entities, потому что он сравнивается по ссылке." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000032"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Struct предпочтителен для любых крупных моделей, так как его копирование всегда дешевле аллокации." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000034"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Class и record имеют одинаковую семантику равенства, различаясь только сокращённым синтаксисом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000041"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Span<T> можно хранить в поле обычного class и свободно использовать после await." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000042"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Memory<T> всегда размещается на стеке и поэтому не подходит для асинхронного кода." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000043"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Создание среза Span<T> копирует исходный диапазон в новый массив." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000052"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "CancellationToken принудительно останавливает поток в любой точке выполнения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000053"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Каждый метод должен создавать собственный CancellationTokenSource и не передавать внешний token." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000054"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "OperationCanceledException всегда следует логировать как необработанную серверную ошибку." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000061"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Все объекты крупнее 85 КБ сразу попадают в поколение 0 и чаще остальных компактируются." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000063"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Server GC гарантирует минимальные паузы и поэтому всегда лучше Workstation GC." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000064"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Высокий working set сам по себе доказывает managed-утечку и не требует анализа heap." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000071"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Закреплённые объекты GC может свободно перемещать, если на них нет managed-ссылок." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000072"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Долгое pinning уменьшает фрагментацию, потому что стабилизирует адреса объектов в heap." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000074"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Любой вызов native API требует навсегда закрепить передаваемый управляемый объект." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000081"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ThreadPool starvation всегда сопровождается загрузкой CPU около 100%." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000082"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Проблему starvation правильно решать только постоянным увеличением MinThreads." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000083"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Асинхронный I/O является основной причиной starvation, даже если нигде нет блокирующих ожиданий." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000092"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ValueTask можно безопасно await-ить много раз и передавать всем consumers как обычный Task." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000093"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ValueTask всегда быстрее Task и должен быть стандартным return type всех async-методов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000094"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ValueTask полезен прежде всего для долгих CPU-bound операций, которые никогда не завершаются синхронно." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000101"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Ковариантность разрешает записывать Animal в коллекцию Dog через IEnumerable<Animal>." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000103"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Контравариантный generic-параметр можно использовать только в возвращаемых значениях." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000104"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Вариантность одинаково работает для ссылочных и значимых типов без ограничений." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000111"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Если hash codes совпали, Equals обязан вернуть true." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000112"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Hash code ключа можно менять после добавления в Dictionary — коллекция пересчитает bucket автоматически." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000114"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Entity и value object всегда следует сравнивать по всем изменяемым свойствам." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000121"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Dispose должен освобождать также ресурсы, которыми объект не владеет." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000122"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "IAsyncDisposable полностью заменяет IDisposable даже для чисто синхронных ресурсов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000123"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Финализатор нужен каждому IDisposable-классу независимо от наличия unmanaged-ресурсов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000132"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "lock можно удерживать через await, и continuation гарантированно вернётся под тем же lock." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000133"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ReaderWriterLockSlim всегда быстрее lock при любом соотношении чтений и записей." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000134"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "SemaphoreSlim гарантирует строгий FIFO-порядок ожидающих операций." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000141"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "volatile делает атомарным любое выражение, использующее помеченное поле." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000143"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Interlocked защищает согласованность произвольного набора связанных полей." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000144"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "lock нужен только для видимости памяти, но не для атомарности составного перехода состояния." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000151"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Достаточно атомарно заменить ссылку, даже если опубликованный граф продолжает изменяться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000152"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Immutable-снимок обязательно публиковать только внутри глобального lock для всех readers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000154"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Volatile.Read создаёт глубокую копию объекта и изолирует вложенные коллекции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000161"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Reflection полностью проверяется компилятором и не создаёт проблем для trimming." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000162"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Кэширование MetadataInfo устраняет любой overhead динамического вызова и boxing." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000163"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Source generator выполняет reflection при каждом runtime-вызове, но на отдельном потоке." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000172"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Tiered compilation сразу компилирует весь код с максимальными оптимизациями до запуска." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000173"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Dynamic PGO использует только статические подсказки разработчика и не учитывает runtime-профиль." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000174"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Native AOT поддерживает все сценарии динамической генерации кода без дополнительных настроек." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000181"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Publisher хранит только слабую ссылку на подписчика, поэтому event не может удерживать объект." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000183"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Отписка не нужна, если обработчик был добавлен через lambda." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000184"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Утечка возможна только тогда, когда subscriber живёт дольше publisher." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000191"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Исключения дешевле условного перехода и подходят для частого ожидаемого результата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000192"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Try-методы следует использовать только для фатальных ошибок, которые нельзя обработать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000194"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Любое доменное отклонение обязательно выражать exception независимо от частоты сценария." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000201"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Nullable reference types добавляют runtime-проверку перед каждым обращением к ссылке." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000202"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Оператор ! преобразует nullable-объект в ненулевой и создаёт экземпляр при null." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000203"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "После включения NRT входные данные и результаты reflection больше не требуют валидации." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000212"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Lambda с захватом локальной переменной никогда не создаёт дополнительных объектов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000213"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "static lambda всё равно неявно захватывает this и все локальные переменные метода." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000214"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Closure-аллокации всегда значимее читаемости, поэтому их нужно устранять без профилирования." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000221"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "LINQ-запрос выполняется полностью в момент объявления переменной." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000223"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Повторное перечисление ленивой последовательности всегда использует закэшированный результат." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000224"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Материализация через ToList сохраняет связь с DbContext и повторяет SQL при каждом чтении." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000231"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Task.WhenAll прекращает остальные задачи сразу после первой ошибки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000232"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "await Task.WhenAll гарантированно пробрасывает AggregateException со всеми ошибками напрямую." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000234"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Отмена одной дочерней задачи автоматически отменяет все остальные без общего token." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000241"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Unbounded Channel обеспечивает backpressure, автоматически блокируя producer при росте очереди." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000242"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Число consumers можно увеличивать бесконечно: downstream и connection pools не влияют." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000243"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "При закрытии pipeline достаточно прекратить producer, ошибки и завершение consumers распространятся сами." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000252"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Собственный финализатор безопаснее SafeHandle, потому что выполняется в предсказуемый момент." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000253"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "SafeHandle освобождает только managed-память и не предназначен для native handles." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000254"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Dispose гарантирует вызов даже при аварийном завершении процесса, поэтому SafeHandle не нужен." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000261"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Generic-код всегда boxing-ит значимый тип перед любой операцией." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000263"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Приведение struct к object сохраняет значение на стеке без упаковки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000264"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Generic constraints не влияют на boxing при вызове интерфейсных методов значимого типа." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000271"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "in гарантирует, что вызывающий метод никогда не создаст защитную копию struct." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000272"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ref readonly разрешает изменять исходное значение только через возвращённую ссылку." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000274"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "scoped продлевает lifetime ссылки за пределы метода и разрешает сохранить её в heap." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000281"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Value object должен иметь отдельный идентификатор и изменяемый жизненный цикл." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000282"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Для value object достаточно сравнивать ссылки, потому что его поля не определяют равенство." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000283"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Внешняя изменяемая коллекция безопасна внутри immutable value object без defensive copy." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000292"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", ".Result безопасен на сервере без SynchronizationContext и не влияет на ThreadPool." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000293"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ConfigureAwait(false) превращает любую блокировку .Wait в полностью асинхронное ожидание." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000294"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Sync-over-async опасен только в desktop UI и не создаёт latency в ASP.NET Core." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000301"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Retry следует выполнять без лимита, пока зависимость не ответит успешно." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000303"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Все ошибки одинаково транзиентны, поэтому фильтрация исключений не требуется." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000304"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Фиксированная немедленная задержка у всех клиентов предотвращает retry storm лучше jitter." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000311"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "DateTime.Now однозначен при переходе на зимнее время и одинаков на всех серверах." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000312"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "UTC подходит для измерения длительности, потому что системные часы никогда не корректируются." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000314"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Хранить только локальное время безопаснее DateTimeOffset, так как timezone можно восстановить всегда." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000321"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Random.Shared подходит для генерации паролей и security tokens." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000322"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Новый Random с одинаковым seed на каждом запросе повышает непредсказуемость." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000323"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "RandomNumberGenerator нужен для воспроизводимых тестов, а не для криптографических значений." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000332"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "throw ex сохраняет исходный stack trace лучше, чем оператор throw." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000333"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Exception filter выполняется после изменения stack trace внутри catch." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000334"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Перехватывать Exception и сразу бросать новый без inner exception полезно для диагностики." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000341"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Арендованный ArrayPool-массив всегда имеет точно запрошенную длину и заполнен нулями." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000343"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Буфер из ArrayPool можно не возвращать: GC автоматически вернёт его в pool." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000344"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "MemoryPool<T> гарантирует размещение любой памяти только в managed heap." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000351"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "False sharing возникает только когда потоки изменяют одну и ту же переменную." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000352"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Объединение всех счётчиков в одной cache line уменьшает coherence traffic." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000354"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Обычный lock всегда полностью устраняет false sharing независимо от расположения данных." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000361"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "BackgroundService должен игнорировать stoppingToken и завершаться только через kill процесса." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000362"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "При shutdown нужно сразу закрыть connection, не дожидаясь in-flight операций." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000363"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Необработанная ошибка фоновой задачи всегда автоматически и бесконечно перезапускается Host." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000372"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Fire-and-forget Task автоматически продлевает lifetime всех scoped-сервисов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000373"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Исключение ненаблюдаемой задачи гарантированно вернётся в исходный HTTP-запрос." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000374"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Достаточно присвоить Task переменной `_`, чтобы Host дождался её при остановке." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000381"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ConcurrentDictionary.GetOrAdd гарантирует единственный вызов value factory." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000383"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Faulted Task внутри словаря автоматически удаляется и вычисляется заново." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000384"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Side effects в value factory безопасны, потому что проигравшие результаты никогда не создаются." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000391"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "IAsyncEnumerable<T> сначала материализует всю последовательность, затем отдаёт элементы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000392"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "CancellationToken автоматически передаётся iterator без EnumeratorCancellation или WithCancellation." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000394"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Один async enumerator безопасно вызывать конкурентно из нескольких consumers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000401"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Рост working set после нагрузки всегда означает удержание managed-объектов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000402"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Одного heap dump достаточно, чтобы доказать рост и найти динамику удержания." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000403"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Если полный GC не уменьшил working set, причиной обязательно является static event." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000012"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "AsNoTracking помещает entities в ChangeTracker, но запрещает вызывать SaveChanges." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000013"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Tracking всегда быстрее no-tracking, потому что identity resolution не расходует память." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000014"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "AsNoTrackingWithIdentityResolution сохраняет entities в основном DbContext до конца его lifetime." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000021"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "N+1 возникает, когда один SQL-запрос содержит слишком много JOIN." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000023"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Проблему N+1 устраняют вызовом ToList перед каждым обращением к navigation property." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000024"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Lazy loading гарантирует один оптимальный запрос независимо от количества загруженных сущностей." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000031"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Include всегда выбирает только поля итогового DTO и поэтому эффективнее Select." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000032"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Select нельзя использовать для связанных данных без предварительного Include." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000034"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Include обязателен в любой проекции, иначе navigation properties всегда будут null." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000041"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Optimistic concurrency заранее блокирует строку до завершения пользовательского ввода." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000042"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Concurrency token гарантирует автоматическое слияние любых конкурентных изменений." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000043"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "DbUpdateConcurrencyException следует всегда повторять без чтения новых значений и проверки инвариантов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000052"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "DbContext thread-safe и рассчитан на совместное использование всеми запросами приложения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000053"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Singleton DbContext предпочтителен, потому что ChangeTracker кэширует всю базу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000054"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Параллельные async-запросы одного DbContext безопасны, если каждый использует AsNoTracking." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000061"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Split query выполняет один SQL с большим количеством JOIN, а single query — несколько." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000063"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Split query всегда видит единый согласованный снимок без явной транзакции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000064"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Single query не может создавать дублирование строк при нескольких коллекциях Include." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000071"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Keyset pagination использует Skip для всех предыдущих страниц, но кэширует offsets." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000072"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Для keyset достаточно сортировки по неуникальному CreatedAt без дополнительного ключа." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000074"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Keyset позволяет мгновенно перейти на произвольную страницу по её номеру без cursor." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000081"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "DbContext pooling делает один экземпляр DbContext доступным нескольким потокам одновременно." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000082"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "TenantId безопасно сохранить в pooled context один раз в OnConfiguring." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000083"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Context pooling заменяет connection pooling и удерживает одно открытое соединение на весь pool." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000092"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Compiled query создаёт оптимальный индекс и исправляет плохой план базы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000093"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Compiled query особенно полезен для каждого уникального динамического expression tree." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000094"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Компиляция запроса устраняет network latency и стоимость materialization результатов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000101"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Встраивание новых констант в expression tree повышает reuse query cache." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000103"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Параметризация заставляет EF компилировать новую форму запроса для каждого значения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000104"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Query cache EF и plan cache базы никак не зависят от стабильности формы выражения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000111"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "AutoDetectChanges выполняет только O(1) проверку независимо от размера tracked graph." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000112"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Его можно навсегда отключить: SaveChanges всегда самостоятельно обнаружит все изменения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000114"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "DetectChanges нужен только для AsNoTracking queries и не используется tracked entities." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000121"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ExecuteUpdate сначала загружает все entities и вызывает их доменные методы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000122"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ExecuteDelete автоматически синхронизирует уже tracked instances с удалёнными строками." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000123"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Set-based операции всегда применяют настроенный concurrency token без явного условия." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000132"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Execution strategy безопасно повторяет только последний SQL внутри внешней транзакции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000133"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Retry может повторять внешние side effects, потому что EF автоматически откатывает HTTP-вызовы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000134"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Пользовательскую транзакцию следует создавать вне ExecuteAsync, чтобы она пережила все попытки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000141"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Каждый отдельный SQL внутри SaveChanges фиксируется независимо и никогда не образует транзакцию." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000143"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Внешний HTTP-вызов следует выполнять внутри database transaction для полной атомарности." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000144"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Явная транзакция всегда нужна даже для одного обычного SaveChanges." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000151"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Savepoint завершает внешнюю транзакцию и фиксирует все изменения до него." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000152"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "После ошибки SaveChanges EF всегда откатывает всю пользовательскую транзакцию без savepoint." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000154"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Savepoint обеспечивает атомарность между базой и внешним брокером сообщений." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000161"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "При DbUpdateConcurrencyException всегда корректно перезаписать базу значениями клиента." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000162"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Store wins означает повторить исходный UPDATE с прежним concurrency token." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000163"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Merge можно выполнить без повторной проверки бизнес-инвариантов на новых данных." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000172"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Value converter автоматически отслеживает внутренние изменения любого mutable-объекта." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000173"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Owned type всегда хранится в отдельной базе и имеет независимый aggregate lifecycle." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000174"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Приватный конструктор не поддерживается EF, поэтому value object обязан иметь public setters." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000181"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "TPH создаёт отдельную таблицу для каждого concrete type без discriminator." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000183"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "TPT всегда быстрее TPH, потому что нормализация исключает JOIN." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000184"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "TPC хранит общие поля один раз в базовой таблице и не дублирует их." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000191"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Для disconnected update безопасно принять entity из API и вызвать Update для всего графа." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000192"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Пометка всей entity Modified защищает поля, которые клиент не прислал." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000194"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Concurrency token не нужен, если DTO содержит все свойства строки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000201"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "TenantId из request body достаточно надёжен для global query filter." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000202"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "IgnoreQueryFilters невозможно вызвать из application code, поэтому обход изоляции исключён." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000203"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Pooled DbContext автоматически обновляет tenant state для каждого запроса." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000212"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Soft delete требует только IsDeleted; unique indexes и navigation semantics не меняются." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000213"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Global filter применяется также к raw SQL и любому IgnoreQueryFilters." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000214"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Физическая очистка soft-deleted строк никогда не нужна и не влияет на размер базы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000221"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Interceptor — лучшее место для любых бизнес-правил и решений агрегата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000223"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "SaveChanges interceptor выполняется ровно один раз даже при retry execution strategy." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000224"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Interceptors не могут влиять на SQL, connection или результат SaveChanges." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000231"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "FromSqlInterpolated вставляет значения прямо в SQL без параметров." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000232"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Имя таблицы безопасно параметризовать тем же способом, что обычное значение." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000234"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Whitelist не нужен для динамической сортировки, если строка прошла HTML escaping." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000241"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "InMemory provider полностью повторяет constraints, transactions и SQL translation production-базы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000242"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Unit-тест доменного правила надёжнее проводить через InMemory DbContext, чем без EF." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000243"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "SQLite всегда идентичен PostgreSQL по collation, типам и конкурентному поведению." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000252"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Обязательную колонку безопасно переименовать и удалить старую в одном релизе при rolling deployment." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000253"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Backfill большой таблицы следует выполнять одной долгой транзакцией вместе с startup приложения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000254"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Expand-contract означает сначала удалить старую схему, затем адаптировать код." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000261"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Database.Migrate на каждом production-инстансе гарантирует единственного владельца DDL." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000263"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Приложению в production всегда нужны постоянные права изменения схемы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000264"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Если миграция упала на одном инстансе, остальные автоматически откатят её во всех базах." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000271"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Порядок Where-вызовов в LINQ напрямую задаёт порядок колонок составного индекса." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000272"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "EF автоматически создаёт оптимальные индексы при первом выполнении запроса." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000274"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Если SQL использует индекс, actual plan и число чтений больше проверять не нужно." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000281"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Cartesian explosion возникает только при последовательных запросах split query." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000282"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Две sibling-коллекции по 10 элементов возвращают максимум 20 строк на root." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000283"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "AsNoTracking устраняет дублирование данных, передаваемых SQL JOIN по сети." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000292"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Максимально большой batch всегда повышает throughput без влияния на locks и параметры." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000293"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "SaveChanges отправляет отдельный network roundtrip на каждую entity независимо от provider." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000294"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Bulk copy вызывает доменные методы каждой entity и полностью эквивалентен обычному tracking." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000301"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Непереводимая функция в Where автоматически выполняется на клиенте над всей таблицей без предупреждения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000303"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "AsEnumerable перед фильтром заставляет оставшуюся часть запроса выполниться в базе." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000304"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Любой .NET-метод можно перевести в SQL, если запрос использует AsNoTracking." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000311"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Read-only DTO требует Include всех navigation properties перед Select." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000312"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Проекция материализует полный tracked aggregate, а потом копирует нужные поля." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000314"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Фильтрацию и пагинацию эффективнее применять после ToList на клиенте." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000321"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "AsNoTrackingWithIdentityResolution добавляет entities в основной ChangeTracker для SaveChanges." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000322"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Обычный AsNoTracking всегда возвращает один object instance для каждой повторяющейся строки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000323"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Identity resolution ускоряет любую плоскую scalar projection и поэтому нужна по умолчанию." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000332"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Cascade delete между любыми агрегатами всегда безопаснее Restrict." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000333"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Граница агрегата не связана с lifecycle dependents и поведением удаления." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000334"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Database cascade обязательно вызывает доменные методы удаляемых entities." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000341"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Outbox message можно сохранить после commit основной транзакции без риска dual write." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000343"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Publisher должен удалить outbox row до получения broker confirm." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000344"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Transactional outbox гарантирует отсутствие дубликатов и отменяет идемпотентность consumer." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000351"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Generic repository необходим поверх DbContext для доступа ко всем возможностям IQueryable." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000352"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "CRUD repository автоматически защищает aggregate boundaries независимо от его методов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000354"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Возврат IQueryable из repository полностью скрывает persistence и сохраняет доменный контракт." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000361"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "JSON-колонка всегда быстрее нормализованных таблиц для joins и constraints." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000362"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "EF отслеживает любые внутренние изменения JSON-графа без comparer и snapshot." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000363"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Поля JSON следует использовать для независимых сущностей с собственным lifecycle и foreign keys." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000372"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Async replica гарантирует немедленный read-your-writes после commit на primary." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000373"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Все запросы после команды можно безусловно направлять на replica без учёта lag." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000374"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "EF автоматически выбирает primary или replica на основе требуемой бизнес-консистентности." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000381"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "В distributed cache безопасно хранить tracked entities вместе с их DbContext." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000383"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Одинаковый cache key можно использовать для всех tenants и параметров запроса." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000384"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Большой TTL гарантирует актуальность критичных данных и устраняет необходимость invalidation." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000391"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Для диагностики достаточно измерить время LINQ до вызова ToListAsync." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000392"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Если HTTP-запрос медленный, причиной всегда является runtime overhead EF." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000394"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Сгенерированный SQL не нужен: Include и Select одинаково выполняются у всех providers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000401"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Read model обязан сохранять ту же нормализованную структуру, что write aggregates." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000402"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Отдельная проекция всегда синхронна и не создаёт компромисса по свежести." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000403"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Сложность постоянных joins лучше решать добавлением новых Include без анализа read requirements." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000012"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Direct exchange поддерживает шаблоны * и #, а topic сравнивает только точное значение." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000013"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Fanout учитывает routing key и выбирает одну наиболее подходящую очередь." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000014"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Headers exchange маршрутизирует только по имени queue и игнорирует headers сообщения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000021"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "At-least-once исключает повторную доставку, если queue объявлена durable." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000023"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Consumer должен отправить ack до выполнения side effect, чтобы сообщение не повторилось." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000024"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Publisher confirms заменяют идемпотентность consumer и гарантируют единственную обработку." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000031"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "DLX получает только сообщения, которые consumer успешно подтвердил." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000032"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Dead-letter queue автоматически исправляет poison message и возвращает его в исходную очередь." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000034"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Для retry достаточно бесконечно nack-ать сообщение с requeue=true без задержки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000041"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Prefetch ограничивает общее число сообщений в queue, а не unacked deliveries consumer." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000042"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Чем выше prefetch, тем всегда ниже latency и справедливее распределение." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000043"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Prefetch=1 обеспечивает максимальный throughput для любой I/O-bound обработки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000052"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "RabbitMQ гарантирует глобальный порядок завершения при любом числе consumers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000053"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Повторная доставка сохраняет исходную позицию сообщения и не влияет на наблюдаемый порядок." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000054"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Persistent delivery mode обеспечивает строгий порядок между разными queues и channels." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000061"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Consumer ack подтверждает publisher, что сообщение было записано на диск broker." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000063"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Publisher confirm означает, что consumer уже успешно выполнил бизнес-операцию." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000064"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Оба механизма покрывают один участок доставки и полностью взаимозаменяемы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000071"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Durable queue автоматически делает все сообщения persistent и подтверждёнными." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000072"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Persistent message невозможно потерять даже без publisher confirms." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000074"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Auto-ack consumer безопасен после записи в TCP socket, потому что broker повторит сообщение при crash." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000081"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Quorum queue подходит для transient и exclusive очередей с частым созданием." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000082"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Classic queue всегда реплицирует сообщения на большинство узлов кластера." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000083"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Quorum queue даёт меньшую latency без дополнительного disk и network overhead." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000092"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Quorum queue продолжает подтверждать записи без большинства, выбирая availability." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000093"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Timeout publish доказывает, что сообщение точно не было записано ни на одну реплику." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000094"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Любая одиночная surviving replica может самостоятельно подтвердить новую запись." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000101"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Для идемпотентности достаточно проверить inbox SELECT, затем отдельно выполнить INSERT." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000103"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "MessageId следует генерировать заново при каждом retry одного бизнес-намерения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000104"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Ack до database commit предотвращает дубликаты надёжнее unique constraint." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000111"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Exactly-once обеспечивает persistent flag без участия приложения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000112"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Broker атомарно согласует consumer ack с любой внешней базой данных." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000114"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Отсутствие дубликатов транспортного delivery означает единственное выполнение side effect." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000121"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "CPU-bound consumer должен иметь prefetch значительно больше любого возможного параллелизма." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000122"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "I/O-bound обработке всегда нужен prefetch=1 независимо от latency downstream." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000123"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Prefetch выбирают только по размеру сообщения, не учитывая processing time и redelivery." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000132"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "nack с requeue=true всегда добавляет экспоненциальную задержку перед повтором." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000133"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Hot loop снижает нагрузку, потому что сообщение остаётся внутри broker без network traffic." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000134"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Бесконечный immediate requeue предпочтительнее retry queue для постоянных ошибок." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000141"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Poison message следует подтверждать как успешное и молча удалять без telemetry." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000143"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Неограниченные retries гарантируют, что постоянная ошибка со временем станет транзиентной." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000144"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "DLQ не требует alert, анализа причины или контролируемого replay." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000151"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Одна queue со смешанными произвольными TTL всегда выдаёт истёкшие сообщения точно по времени." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000152"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Dead-lettering по умолчанию гарантирует exactly-once перенос в retry queue." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000154"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Для сложного расписания достаточно одного TTL на queue без отдельных buckets." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000161"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Publisher confirm гарантирует, что сообщение попало хотя бы в одну ожидаемую queue." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000162"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "mandatory=false возвращает unroutable message издателю через basic.return." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000163"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Публикация в существующий exchange всегда успешна, даже если нет bindings." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000172"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Automatic recovery делает определённым исход всех in-flight publishes." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000173"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "После reconnect старые channels продолжают работать с прежними delivery tags." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000174"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Topology recovery автоматически откатывает внешние side effects незавершённых handlers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000181"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Один channel безопасно используется неограниченным числом concurrent publishers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000183"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Frames разных сообщений можно перемешивать: broker самостоятельно восстановит границы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000184"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Confirm sequence numbers глобальны для connection и не зависят от channel." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000191"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Ack с multiple=true подтверждает только один exact sequence number." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000192"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "После connection loss все outstanding publishes считаются гарантированно потерянными." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000194"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Ожидание individual confirm после каждого сообщения даёт максимальный publisher throughput." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000201"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Stream удаляет запись сразу после первого consumer ack, как обычная work queue." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000202"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Streams не поддерживают replay и предназначены только для временных RPC-ответов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000203"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Queue лучше stream для огромного append-only backlog и независимых offsets множества readers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000212"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Super stream сохраняет один глобальный порядок между всеми partitions." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000213"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Случайный routing каждого события aggregate повышает порядок и consistency." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000214"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Hot key равномерно распределяется по partitions автоматически внутри одного сообщения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000221"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Breaking изменение существующего поля безопасно, если producer обновился первым." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000223"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Consumer должен отвергать payload с любым неизвестным optional полем." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000224"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Schema version не нужен, потому что все сервисы разворачиваются атомарно." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000231"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Domain event является стабильным публичным контрактом и обязан напрямую сериализоваться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000232"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Integration event должен содержать весь внутренний aggregate graph." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000234"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Разделение типов увеличивает coupling, потому что внешний consumer не видит private domain model." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000241"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Outbox устраняет необходимость publisher confirms и consumer idempotency." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000242"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Dispatcher помечает запись отправленной до publish, чтобы избежать дубликата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000243"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Сохранение outbox после основной транзакции гарантирует отсутствие потери сообщения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000252"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Один aggregate следует распределять по случайным queues для сохранения порядка." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000253"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Глобальный порядок и линейное масштабирование consumers достигаются одновременно без partition key." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000254"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Version check не нужен при out-of-order доставке, потому что broker отсортирует события на consumer." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000261"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Queue depth в одиночку полностью описывает latency и здоровье consumers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000263"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Возраст старейшего сообщения неважен, если глубина очереди временно стабильна." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000264"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Redelivery rate и unacked не дают информации о poison loops и медленной обработке." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000271"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Любой ненулевой backlog означает инцидент независимо от arrival rate." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000272"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Если queue depth не растёт, возраст сообщений также не может расти." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000274"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Drain time определяют только по числу consumers, не учитывая их processing rate." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000281"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Memory alarm ускоряет publishers, чтобы быстрее освободить queue." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000282"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "При disk alarm broker удаляет persistent messages и продолжает подтверждать новые." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000283"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Producer может бесконечно буферизовать blocked publishes в памяти без собственного лимита." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000292"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Health check должен создавать новое connection и channel на каждый HTTP-запрос." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000293"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Недоступность broker всегда означает, что liveness должна немедленно убить процесс." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000294"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Readiness и liveness имеют одинаковую семантику для любой messaging-зависимости." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000301"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "При shutdown сначала закрывают connection, затем ждут завершения handlers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000303"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Unacked in-flight сообщения исчезают после закрытия consumer и не доставляются повторно." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000304"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Graceful shutdown не нуждается в timeout, потому что обработка гарантированно завершится." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000311"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Большой payload уменьшает replication traffic, потому что broker лучше его сжимает автоматически." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000312"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Blob безопаснее всегда передавать внутри queue, чтобы не управлять lifetime object storage." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000314"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Message size влияет только на сеть consumer и не затрагивает broker memory или disk." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000321"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Один огромный batch упрощает retry, потому что ошибка одного элемента не затрагивает остальные." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000322"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Business event должен объединять все факты за час ради минимального числа сообщений." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000323"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Частичный результат batch никогда не требует idempotency отдельных элементов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000332"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Broker гарантирует, что один MessageId не будет одновременно доставлен двум consumers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000333"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Distributed lock полностью заменяет unique constraint и идемпотентную транзакцию." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000334"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "SELECT processed_messages перед side effect атомарно защищает от concurrent duplicate." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000341"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Single Active Consumer параллельно активирует всех consumers, но сохраняет глобальный порядок." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000343"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "SAC увеличивает throughput одной queue пропорционально числу зарегистрированных consumers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000344"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Failover SAC никогда не создаёт redelivery незавершённого сообщения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000351"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Большое число уровней priority не влияет на CPU и внутренние структуры queue." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000352"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Низкоприоритетные сообщения гарантированно обслуживаются при постоянном потоке высокого приоритета." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000354"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Priority полностью заменяет отдельные queues с разными SLA и capacity." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000361"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Каждая новая queue бесплатна по памяти, метаданным и recovery time." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000362"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Quorum queue не добавляет replicas и consensus overhead по сравнению с binding." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000363"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Queue следует создавать для каждого message instance ради максимальной изоляции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000372"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Событие выражает просьбу конкретному handler и может быть отклонено как команда." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000373"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Команда описывает уже свершившийся факт и должна иметь множество независимых владельцев." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000374"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Название контракта не влияет на retry, routing и ответственность получателя." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000381"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Request/reply через broker всегда быстрее прямого HTTP для короткой операции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000383"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Timeout ожидания ответа гарантированно отменяет уже принятую consumer работу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000384"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Correlation state и временные reply queues не добавляют новых failure modes." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000391"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Happy-path теста достаточно, потому что confirms исключают неопределённые исходы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000392"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Crash после commit до ack не нужно тестировать: broker знает о database transaction." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000394"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Duplicate, out-of-order и потеря quorum невозможны в production-кластере." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000401"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Для трассировки достаточно timestamp; message id и causation id не нужны." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000402"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Безопасно логировать весь payload каждого сообщения независимо от персональных данных." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000403"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Consumer span не должен связываться с publish context, потому что обработка асинхронна." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000012"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "MVCC обновляет строку на месте, поэтому старых версий после UPDATE не существует." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000013"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "VACUUM блокирует все чтения таблицы и всегда возвращает свободное место операционной системе." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000014"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Autovacuum нужен только для обновления индексов и не связан с transaction ID wraparound." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000021"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Hash индекс поддерживает range scan и ORDER BY лучше B-tree." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000023"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "GIN оптимален для любого точечного равенства scalar-колонки и почти не влияет на запись." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000024"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "GiST хранит точную копию каждого значения и никогда не требует recheck." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000031"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Seq Scan всегда означает ошибку планировщика и отсутствующий индекс." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000032"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Если estimated cost мал, actual rows и loops можно не анализировать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000034"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "EXPLAIN ANALYZE только строит план и никогда реально не выполняет запрос." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000041"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Read Uncommitted в PostgreSQL допускает dirty reads и слабее Read Committed." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000042"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Serializable блокирует все строки при первом SELECT и никогда не требует retry." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000043"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Repeatable Read видит committed изменения между двумя SELECT одной транзакции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000052"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Наличие любого индекса обязывает planner использовать его." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000053"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Leading wildcard эффективно обслуживается обычным B-tree без специальных операторов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000054"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Устаревшая статистика влияет только на отображение EXPLAIN, но не на выбор плана." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000061"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Длинная idle transaction помогает VACUUM быстрее определить ненужные версии." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000063"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Snapshot старой транзакции не влияет на xmin и возможность удаления dead tuples." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000064"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Transaction age связан только с locks и не может привести к bloat или wraparound risk." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000071"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Обычный VACUUM всегда уменьшает размер файла таблицы на диске." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000072"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "VACUUM FULL работает без сильной блокировки и не переписывает таблицу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000074"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Autovacuum безопасно отключить навсегда, если приложение редко вызывает DELETE." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000081"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "HOT update возможен при изменении любой индексированной колонки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000082"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Fillfactor=100 оставляет максимум места на странице для новых версий строки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000083"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "HOT создаёт новые entries во всех индексах и поэтому увеличивает index bloat." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000092"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "В составном B-tree range-колонку всегда ставят первой, затем equality-колонки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000093"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Индекс (a,b) одинаково эффективно обслуживает произвольный фильтр только по b." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000094"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Порядок колонок определяется исключительно их типом, а не predicates и сортировкой." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000101"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "INCLUDE-колонки участвуют в поисковом ключе и определяют порядок B-tree." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000103"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "INCLUDE уменьшает размер индекса и стоимость каждого UPDATE." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000104"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Наличие всех колонок в индексе гарантирует index-only scan независимо от visibility map." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000111"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Index-only scan никогда не обращается к heap, потому что индекс хранит MVCC visibility." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000112"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Недавно изменённые страницы сразу становятся all-visible до VACUUM." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000114"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Planner обязан выбрать index-only scan, если SELECT перечисляет только индексные колонки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000121"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Partial index используется для любого запроса, даже если planner не может доказать predicate." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000122"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Полный индекс всегда меньше partial, потому что не хранит условие." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000123"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Параметризованный WHERE гарантированно совпадает с любым partial-index predicate." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000132"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Expression index вычисляет функцию только при SELECT и не влияет на writes." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000133"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "В expression index безопасно использовать volatile-функцию, зависящую от текущего времени." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000134"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Запрос по lower(email) автоматически использует обычный индекс по email." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000141"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Статистика отдельных колонок точно оценивает любую корреляцию между ними." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000143"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Extended statistics собирают распределение значений между разными таблицами." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000144"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "CREATE STATISTICS заменяет ANALYZE и обновляется синхронно после каждой строки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000151"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Nested loop лучше hash join для любых двух больших таблиц без индекса." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000152"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Hash join поддерживает только range condition и не используется для equality." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000154"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Merge join не требует сортировки или упорядоченных индексов на входах." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000161"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "work_mem выделяется один раз на connection и делится между всеми узлами плана." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000162"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Максимально большое глобальное work_mem безопасно при любом числе concurrent queries." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000163"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Sort spill во временный файл не влияет на latency и disk I/O." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000172"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Большое Rows Removed by Filter всегда требует индекс даже для таблицы из десяти строк." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000173"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Эта метрика показывает строки, удалённые предыдущей транзакцией через DELETE." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000174"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Loops не влияет на итоговое число отфильтрованных строк при чтении плана." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000181"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "EXPLAIN ANALYZE для DELETE только симулирует удаление без изменения данных." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000183"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "BEGIN автоматически отменит выполненный UPDATE даже без ROLLBACK." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000184"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "На production ANALYZE не создаёт нагрузки, потому что executor не читает страницы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000191"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Generic plan всегда оптимален для любого распределения значений параметра." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000192"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Prepared statement компилируется только один раз и никогда не выбирает custom plan." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000194"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Data skew не влияет на выбор между index scan и sequential scan." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000201"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Ожидающие locks обслуживаются вне очереди, поэтому новый SELECT всегда обходит DDL." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000202"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Любого blocker безопасно немедленно kill-нуть: rollback всегда мгновенный." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000203"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Root blocker определяется только максимальным PID, без анализа pg_locks." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000212"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Deadlock — это любое ожидание lock дольше deadlock_timeout." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000213"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "PostgreSQL разрешает цикл ожиданий, выбирая транзакцию с самым ранним стартом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000214"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Единый порядок захвата ресурсов увеличивает вероятность deadlock." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000221"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "SELECT FOR UPDATE не блокирует конкурентный UPDATE выбранной строки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000223"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "SKIP LOCKED обеспечивает полный согласованный снимок и подходит для финансовых отчётов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000224"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Для worker queue всем workers следует ждать одну locked строку без SKIP LOCKED." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000231"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Serializable в PostgreSQL реализован глобальной блокировкой всей базы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000232"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Serialization failure можно повторить только с тем же старым snapshot." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000234"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Внешний side effect внутри повторяемой транзакции безопасно выполнять при каждой попытке." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000241"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Read Committed использует один snapshot на всю транзакцию." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000242"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Два SELECT в Read Committed обязаны видеть одинаковые строки после чужого commit." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000243"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Для atomic read-modify-write достаточно двух statements без lock или условия версии." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000252"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Advisory lock автоматически привязан к foreign key и проверяется всеми SQL-запросами." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000253"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Session-level advisory lock всегда освобождается после каждой транзакции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000254"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Коллизия application-defined ключей невозможна, даже если команды используют разные схемы кодирования." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000261"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "SELECT перед INSERT устраняет race так же атомарно, как ON CONFLICT." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000263"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ON CONFLICT не использует unique constraint и работает по любому произвольному условию." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000264"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "UPSERT автоматически сохраняет инварианты нескольких несвязанных строк без транзакции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000271"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Partition key не обязан участвовать в predicates основных запросов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000272"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Чем больше partitions, тем всегда быстрее planning и меньше metadata overhead." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000274"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Глобальный unique constraint легко создаётся без partition key во всех схемах partitioning." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000281"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Partitioning автоматически ускоряет любой запрос независимо от pruning." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000282"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Каждая partition не нуждается в собственных индексах и статистике." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000283"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Hash partition по случайному ключу идеально подходит для быстрого удаления данных по времени." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000292"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Одна DELETE миллионов строк сразу освобождает файл и почти не генерирует WAL." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000293"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Drop старой time partition выполняет row-by-row deletes внутри каждой страницы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000294"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Batch deletion увеличивает длительность locks по сравнению с одной огромной транзакцией." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000301"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Physical replication передаёт только выбранные таблицы и допускает разную схему target." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000303"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Logical replication автоматически реплицирует любой DDL и sequences без настройки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000304"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Async replica всегда имеет нулевой lag и гарантирует read-your-writes." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000311"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "RPO описывает только время переключения, а RTO — допустимую потерю данных." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000312"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Асинхронная replica гарантирует RPO=0 при потере primary." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000314"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Наличие replica автоматически обеспечивает протестированный failover и fencing." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000321"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Успешный backup job доказывает возможность восстановления без restore-теста." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000322"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Replica является полноценным backup от случайного DELETE и логической corruption." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000323"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "PITR не требует непрерывной цепочки WAL после base backup." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000332"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "WAL записывается после data pages и не участвует в crash recovery." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000333"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Большой UPDATE не влияет на объём WAL и lag replicas." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000334"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Отключение synchronous_commit гарантирует отсутствие потери последних транзакций при crash." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000341"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Чем чаще checkpoints, тем равномернее I/O и меньше full-page images." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000343"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "max_wal_size не влияет на частоту вынужденных checkpoints." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000344"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Checkpoint записывает только WAL и не сбрасывает dirty data pages." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000351"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Каждое PostgreSQL connection почти бесплатно и не потребляет отдельную память." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000352"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Размер connection pool должен равняться числу HTTP-запросов без учёта CPU базы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000354"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Pooler увеличивает число одновременно выполняемых backend queries сверх max_connections." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000361"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Transaction pooling сохраняет session-level SET и temp tables между транзакциями клиента." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000362"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "LISTEN и session advisory locks безопасно работают при случайной смене backend." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000363"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "PgBouncer в transaction mode гарантирует один backend на весь lifetime client connection." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000372"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "BRIN хранит точную запись для каждой строки и поэтому крупнее B-tree." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000373"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "BRIN оптимален для случайно распределённого UUID equality lookup." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000374"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Физическая корреляция значения с порядком страниц не влияет на эффективность BRIN." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000381"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "GIN дешевле обновляется, чем B-tree, и не имеет pending list." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000383"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "GiST всегда точен и никогда не возвращает кандидатов для recheck." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000384"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Для nearest-neighbor поиска подходит только GIN, а GiST не поддерживает distance operators." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000391"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Любое ALTER TYPE является metadata-only и никогда не переписывает таблицу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000392"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Table rewrite не генерирует WAL и выполняется без сильной блокировки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000394"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Expand-contract начинает с удаления старой колонки, чтобы освободить место для новой." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000401"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Если план ухудшился, достаточно навсегда отключить sequential scan." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000402"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Estimated и actual rows не связаны со статистикой и data skew." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000403"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Рост таблицы не может изменить cost balance между index и sequential scan." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000012"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Агрегат объединяет все связанные сущности предметной области в один объектный граф." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000013"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Внешний код может изменять внутренние entities напрямую, если транзакция уже открыта." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000014"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Между агрегатами всегда требуется одна ACID-транзакция и object reference." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000021"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "CQRS требует отдельные базы и event sourcing в каждом проекте." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000023"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "CQRS полезен прежде всего для простого CRUD, где read и write модели совпадают." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000024"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Разделение команд и запросов автоматически даёт независимое масштабирование без инфраструктуры." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000031"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Микросервисы следует выбирать только по количеству строк кода в модуле." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000032"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Модульный монолит не допускает чётких boundaries и независимого ownership." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000034"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Распределённые транзакции и observability микросервисов проще единого deployment." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000041"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Outbox записывается после commit бизнес-данных, поэтому dual write исключён." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000042"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "После outbox consumer больше не обязан быть идемпотентным." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000043"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Publisher удаляет outbox row до отправки, чтобы сообщение не продублировалось." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000052"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Новый idempotency key следует генерировать на каждую retry-попытку одного запроса." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000053"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Достаточно проверить наличие ключа через SELECT, а результат сохранить отдельной транзакцией." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000054"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Одинаковый ключ с другим payload следует считать тем же запросом и молча вернуть старый ответ." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000061"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Bounded context и микросервис — одно понятие и всегда имеют отношение один к одному." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000063"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Bounded context определяется deployment pipeline, а не границей языка и модели." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000064"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Один термин обязан иметь одинаковый смысл во всех contexts большой организации." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000071"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Invariant может быть временно нарушен после успешной команды внутри агрегата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000072"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Граница агрегата определяется удобством eager loading, а не transactional consistency." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000074"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Чем больше aggregate graph, тем выше concurrency и меньше конфликтов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000081"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Eventual consistency означает отсутствие срока, статуса и обработки неуспеха." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000082"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Она подходит для правила, которое нельзя нарушать даже на миллисекунду." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000083"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Пользователь всегда должен видеть состояние как завершённое, скрывая pending и compensation." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000092"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Saga откатывает распределённые транзакции побайтово как единый database rollback." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000093"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Choreography всегда проще orchestration независимо от числа шагов и ветвлений." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000094"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Компенсирующее действие гарантированно возвращает внешний мир в точное прежнее состояние." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000101"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Distributed transaction повышает availability, потому что связывает commit всех участников." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000103"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Она поддерживается любыми HTTP API и брокерами без дополнительного протокола." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000104"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "При её использовании failure policy и компенсации больше не нужны." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000111"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Стабильная бизнес-политика должна зависеть от конкретного ORM и transport framework." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000112"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Если два модуля меняются вместе, это всегда доказывает правильное направление зависимости." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000114"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Общий mutable domain model уменьшает coupling между независимыми owners." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000121"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Clean Architecture автоматически создаёт правильные bounded contexts и domain invariants." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000122"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Каждый use case обязан иметь по семь pass-through слоёв независимо от сложности." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000123"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Domain должен ссылаться на Infrastructure, чтобы знать, как сохраняются entities." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000132"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Write repository должен возвращать IQueryable, чтобы вызывающий обходил aggregate root." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000133"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Read-only экран обязан материализовать полный tracked aggregate перед созданием DTO." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000134"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Generic CRUD repository всегда лучше специализированного доменного контракта." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000141"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Domain event следует публиковать во внешний broker прямо из метода aggregate." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000143"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Любой handler domain event гарантированно выполняется ровно один раз без явной политики." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000144"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Внутренний domain event обязан быть тем же versioned контрактом, что integration event." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000151"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Несколько агрегатов всегда следует увеличить до одного огромного aggregate." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000152"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Если операция затрагивает две сущности, strong consistency обязательна независимо от бизнеса." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000154"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Eventual consistency не требует pending state, retry или compensation." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000161"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Ubiquitous language — единый словарь на всю компанию без bounded-context различий." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000162"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Имена в коде можно не связывать с языком экспертов, если есть техническая документация." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000163"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Два разных понятия полезно называть одним универсальным Entity для повторного использования." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000172"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Anemic model всегда предпочтительна для сложного поведения, потому что setters гибче." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000173"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Rich domain model требует помещать SQL и HTTP-вызовы внутрь entity." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000174"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Даже простой CRUD обязан содержать сложные aggregates и domain services." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000181"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Modular monolith означает общие таблицы и прямые вызовы внутренних классов всех модулей." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000183"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Он исключает последующее выделение сервиса, потому что имеет один deployment." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000184"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Его выбирают только когда независимые команды уже требуют отдельного масштабирования." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000191"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Большой размер codebase сам по себе является достаточной причиной микросервисов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000192"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Выделение сервиса уменьшает observability и operational cost до нуля." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000194"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Нестабильную доменную границу лучше немедленно закрепить отдельной сетью и базой." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000201"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Coupling существует только при compile-time reference между assemblies." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000202"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Temporal и algorithm connascence безопасны через сеть, потому что не видны компилятору." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000203"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Сильные формы связи лучше распределять между удалёнными командами, а не локализовать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000212"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Публичный API безопасно сериализует внутреннюю entity со всеми navigation properties." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000213"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Любое добавление optional поля является breaking change и требует новой major version." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000214"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Старую версию можно удалить сразу после deployment новой без telemetry consumers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000221"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Idempotency key относится к одной HTTP-попытке, а не к бизнес-намерению." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000223"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Серверу не нужно сравнивать fingerprint payload при повторном ключе." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000224"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Ключи следует хранить вечно глобально без scope пользователя и операции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000231"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Retry, timeout и circuit breaker выполняют одну функцию и полностью взаимозаменяемы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000232"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Circuit breaker должен повторять каждый запрос чаще, когда dependency явно нездорова." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000234"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Retry без общего deadline и jitter уменьшает нагрузку при массовом отказе." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000241"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Bulkhead объединяет все workloads в один pool для максимальной утилизации." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000242"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Он нужен только для database locks и не применяется к queues или connections." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000243"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Чем больше изоляционных partitions, тем всегда выше efficiency без overhead." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000252"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "При перегрузке upstream должен бесконечно накапливать запросы в unbounded memory." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000253"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "429 и явный reject хуже скрытого timeout, потому что клиент узнаёт о насыщении." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000254"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Retry без учёта backpressure ускоряет восстановление downstream." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000261"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "SLI — желаемая цель, SLO — конкретная измеряемая метрика, а error budget не связан с ними." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000263"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Средняя latency всех endpoint является достаточным SLI пользовательского успеха." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000264"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Error budget должен всегда равняться нулю, иначе система считается ненадёжной." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000271"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Среднее значение точно отражает редкие медленные запросы и tail latency." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000272"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "При fan-out latency результата равна среднему downstream, а не максимуму." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000274"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "p99 не связан с saturation и очередями, поэтому его нельзя улучшить capacity limits." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000281"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Distributed trace заменяет metrics, logs и profiles во всех расследованиях." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000282"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Sampling гарантированно сохраняет каждый редкий ошибочный trace." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000283"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Trace без корректной context propagation всё равно точно показывает causality." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000292"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Shared-table multi-tenancy не требует tenant key в каждом запросе." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000293"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Database-per-tenant всегда дешевле и проще для любого количества маленьких tenants." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000294"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Noisy neighbor устраняется только шифрованием данных, без quotas и resource isolation." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000301"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Cache-aside гарантирует strong consistency между cache и database." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000303"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "После write достаточно обновить базу: stale cache сам мгновенно узнает об изменении." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000304"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Кэширование tracked domain entities безопасно между requests и DbContexts." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000311"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Одинаковый TTL всех hot keys предотвращает одновременное истечение и stampede." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000312"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "При cache miss каждый concurrent request должен независимо обратиться к source." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000314"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Distributed lock без timeout и fallback является самым безопасным решением." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000321"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Event sourcing нужен всякий раз, когда бизнес просит обычный audit log." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000322"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Event store хранит только текущее состояние, а старые события перезаписываются." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000323"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Replay не требует детерминированных handlers или эволюции contracts." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000332"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Старые события следует массово переписывать при каждом изменении domain model." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000333"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Новый consumer может предполагать, что в истории есть только последняя версия события." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000334"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Upcaster изменяет исходный event store на месте и удаляет прежний факт." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000341"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Snapshot является источником истины и позволяет удалить все исходные events." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000343"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Snapshot нужно создавать после каждого события независимо от измеренной стоимости." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000344"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Изменение модели не требует versioning или rebuild старых snapshots." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000351"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Anti-corruption layer экспортирует внутреннюю модель legacy-системы без перевода." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000352"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ACL нужен только как HTTP retry wrapper и не связан с ubiquitous language." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000354"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Чем нестабильнее внешний контракт, тем полезнее использовать его entities напрямую в domain." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000361"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Context map описывает только network topology и не отражает отношения ownership." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000362"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Conformist означает, что downstream полностью управляет контрактом upstream." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000363"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Published language не нуждается в стабильности или согласовании между командами." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000372"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Shared database сохраняет независимость сервисов, если таблицы имеют разные префиксы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000373"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Прямое read-only чтение чужой таблицы не создаёт скрытого контракта." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000374"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Общие миграции позволяют сервисам разворачиваться независимо без координации." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000381"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Strangler требует переписать весь legacy до переключения первого пользователя." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000383"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Дублирование двух реализаций без плана выключения является конечной целью pattern." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000384"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Ownership данных неважен, если router умеет распределять HTTP-трафик." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000391"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "ADR должен подробно дублировать каждую строку реализации." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000392"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "При пересмотре решения старый ADR удаляют, чтобы история не вводила в заблуждение." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000394"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Записывать нужно каждое тривиальное решение, иначе архитектура считается недокументированной." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000401"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Build versus buy сравнивают только по цене лицензии первого года." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000402"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Commodity capability всегда нужно писать самостоятельно ради отсутствия vendor lock-in." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000403"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.", "Exit strategy и integration cost можно оценить после необратимого выбора поставщика." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000012"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как диагностировать ThreadPool starvation в ASP.NET Core и чем он отличается от высокой загрузки CPU?». Поэтому он не отвечает на текущую формулировку.", "При starvation запросы ждут свободный worker, latency растёт, а CPU может оставаться умеренным; типичные причины — sync-over-async, блокирующие I/O и долгие locks. Проверяют очередь ThreadPool, число потоков, request latency и stacks через dotnet-counters, dotnet-stack или trace. Исправление — асинхронность по всей цепочке, устранение блокировок и ограничение параллелизма, а не бездумное увеличение MinThreads." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000013"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему подписка на event может вызвать утечку памяти?». Поэтому он не отвечает на текущую формулировку.", "Publisher хранит сильную ссылку на delegate, а delegate — на subscriber, поэтому долгоживущий publisher удерживает подписчика. Нужно явно отписываться, возвращать IDisposable-токен подписки, привязывать время жизни объектов или применять weak-event только при понятной семантике. Анонимная lambda усложняет отписку, если её экземпляр не сохранён." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000014"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать retry для асинхронной операции, чтобы не усугубить отказ?». Поэтому он не отвечает на текущую формулировку.", "Повторяют только транзиентные и идемпотентные операции, используют ограниченное число попыток, exponential backoff с jitter и общий timeout. CancellationToken должен прекращать ожидание. Retry без лимита создаёт retry storm, поэтому его сочетают с circuit breaker, ограничением конкуренции и наблюдаемостью причин." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000021"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда ValueTask оправдан, а когда он только усложняет код?». Поэтому он не отвечает на текущую формулировку.", "ValueTask полезен в очень горячем API, которое часто завершается синхронно и где измерения показывают значимые аллокации Task. Его нельзя бездумно await-ить несколько раз, хранить или комбинировать как обычный Task; часто требуется AsTask. По умолчанию предпочтителен Task, а ValueTask вводят только после профилирования и с ясным контрактом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000023"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему исключения не подходят для обычного управления потоком в горячем коде?». Поэтому он не отвечает на текущую формулировку.", "Создание и обработка исключения существенно дороже обычной ветки и искажает telemetry, если ожидаемые ситуации выглядят как ошибки. Для вероятного неуспеха лучше Try-методы, Result или явный union. Исключение остаётся правильным для нарушения контракта и действительно исключительного состояния, особенно когда вызывающий уровень может восстановиться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000024"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие проблемы создаёт DateTime.Now в распределённой системе?». Поэтому он не отвечает на текущую формулировку.", "Локальное время неоднозначно при переходах DST и зависит от timezone машины. Для событий и хранения обычно используют UTC через DateTimeOffset и внедряемый TimeProvider, а локализацию выполняют на границе отображения. Для измерения длительности нужен монотонный Stopwatch, потому что wall clock может корректироваться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000031"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Объясните ковариантность и контравариантность generic-интерфейсов на практическом примере.». Поэтому он не отвечает на текущую формулировку.", "Ковариантный out-параметр позволяет использовать источник более конкретного типа как источник базового, например IEnumerable<Dog> как IEnumerable<Animal>. Контравариантный in-параметр позволяет обработчику базового типа обслуживать конкретный, например IComparer<Animal> для Dog. Вариантность безопасна только для ссылочных типов и ограничивает позиции чтения и записи параметра." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000032"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что реально дают nullable reference types и где остаются границы их гарантий?». Поэтому он не отвечает на текущую формулировку.", "NRT — статический анализ аннотаций, а не runtime-защита: он уменьшает число случайных null, но внешние данные, reflection, старые библиотеки и неверный оператор ! могут нарушить контракт. На границах всё равно нужна runtime-валидация. Аннотации следует согласовывать с доменной семантикой, а не отключать предупреждения массовыми подавлениями." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000034"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как безопасно использовать Random в конкурентном приложении и когда нужен криптографический генератор?». Поэтому он не отвечает на текущую формулировку.", "Для симуляций и некритичных значений используют Random.Shared, который безопасен для параллельного доступа. Токены, пароли, nonce и идентификаторы безопасности требуют RandomNumberGenerator. Seeded Random полезен для воспроизводимых тестов, но его предсказуемость делает его непригодным для защиты." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000041"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие требования связывают Equals, GetHashCode и использование объекта как ключа Dictionary?». Поэтому он не отвечает на текущую формулировку.", "Если Equals возвращает true, hash code обязан совпадать; обратное не требуется. Поля, участвующие в равенстве и hash code, нельзя менять, пока объект служит ключом, иначе запись станет логически недоступной. Для value object обычно задают структурное равенство, а entity сравнивают по устойчивой идентичности с осторожностью до её назначения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000042"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие скрытые аллокации создают closures и как проверить, что оптимизация действительно нужна?». Поэтому он не отвечает на текущую формулировку.", "Lambda, захватывающая локальные переменные или this, обычно создаёт объект closure и delegate; в цикле это может стать заметным allocation rate. Помогают static lambda, передача state отдельным параметром и кэширование delegate. Но решение принимают по профилю или BenchmarkDotNet, потому что читаемость важнее микроскопической экономии вне горячего пути." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000043"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как правильно повторно выбросить исключение и когда полезны exception filters?». Поэтому он не отвечает на текущую формулировку.", "Внутри catch оператор throw сохраняет исходный stack trace, а throw ex его повреждает. Filter when позволяет классифицировать исключение без входа в catch и не меняет исходный стек; в нём не должно быть side effects. Перехватывают исключение только если добавляют контекст, выполняют восстановление или переводят его на осмысленную границу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000052"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как правильно проектировать IDisposable и IAsyncDisposable для класса с несколькими ресурсами?». Поэтому он не отвечает на текущую формулировку.", "Класс должен освобождать только ресурсы, которыми владеет, быть устойчивым к повторному Dispose и не выполнять работу после освобождения. IAsyncDisposable нужен, когда корректное закрытие требует async I/O; комбинированный тип обычно реализует оба пути и подавляет финализацию. Финализатор нужен только при прямом владении unmanaged-ресурсом, предпочтительно через SafeHandle." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000053"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие ошибки возникают из-за deferred execution в LINQ?». Поэтому он не отвечает на текущую формулировку.", "Запрос выполняется при перечислении, поэтому повторное перечисление может повторить дорогой I/O или увидеть уже изменённое состояние. Возврат ленивой последовательности за пределы lifetime DbContext приводит к сбоям, а side effects внутри Select делают поведение неочевидным. Границу материализации выбирают явно и документируют одноразовые последовательности." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000054"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать между ArrayPool<T>, MemoryPool<T> и обычным массивом?». Поэтому он не отвечает на текущую формулировку.", "Обычный массив проще и безопаснее для долгоживущих данных. ArrayPool снижает давление на GC для частых временных буферов, но арендованный массив может быть больше запрошенного, содержит старые данные и обязан возвращаться в finally; чувствительные данные очищают. MemoryPool удобен для ownership-модели и pipelines, особенно с нестандартной памятью." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000061"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать между lock, SemaphoreSlim, ReaderWriterLockSlim и Channel<T>?». Поэтому он не отвечает на текущую формулировку.", "lock подходит для короткой синхронной критической секции без await. SemaphoreSlim позволяет асинхронно ограничивать конкуренцию, ReaderWriterLockSlim полезен лишь при измеренном преобладании чтений и достаточной длительности операций. Channel<T> часто лучше общей блокировки, когда задачу можно представить как очередь с одним или несколькими потребителями и backpressure." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000063"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как Task.WhenAll сообщает об ошибках и отмене нескольких операций?». Поэтому он не отвечает на текущую формулировку.", "Возвращаемый Task завершается после всех операций; при ошибках он Faulted, а Exception содержит aggregate внутренних ошибок, хотя await обычно пробрасывает одну. Остальные ошибки нужно анализировать через сам Task. Отмена не прекращает уже запущенную работу автоматически: всем операциям передают общий token и отдельно решают политику частичного результата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000064"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое false sharing и как оно проявляется в .NET?». Поэтому он не отвечает на текущую формулировку.", "Независимые значения в одной cache line заставляют ядра постоянно инвалидировать кэш друг друга, поэтому масштабирование ухудшается без логической блокировки. Это видно в высококонкурентных счётчиках и массивах состояния. Помогают разбиение счётчиков, локальная агрегация и иногда padding, но подтверждать причину нужно аппаратными метриками и benchmark." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000071"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что гарантирует volatile, а что требует Interlocked или lock?». Поэтому он не отвечает на текущую формулировку.", "volatile задаёт семантику чтения и записи с барьерами видимости, но не делает составные операции вроде increment атомарными и не защищает инвариант нескольких полей. Interlocked подходит для атомарных операций над отдельным значением. Если переход состояния затрагивает несколько значений или требует проверки-изменения, нужен lock либо другая синхронизация." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000072"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как спроектировать ограниченный асинхронный pipeline с backpressure?». Поэтому он не отвечает на текущую формулировку.", "Используют bounded Channel или очередь с ограниченной ёмкостью, чтобы быстрый producer ждал либо применял явную политику drop. Число consumers ограничивают по характеру работы, ошибки и завершение канала распространяют явно, CancellationToken проходит по всей цепочке. Метрики глубины очереди и времени ожидания показывают, где находится bottleneck." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000074"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как организовать graceful shutdown фоновых задач в Generic Host?». Поэтому он не отвечает на текущую формулировку.", "BackgroundService должен уважать stoppingToken, не запускать fire-and-forget работу без учёта и завершать приём новых задач до дренирования текущих. На остановке учитывают host shutdown timeout, корректно закрывают каналы и освобождают ресурсы. Необработанная ошибка фоновой задачи должна быть наблюдаемой и иметь явную политику остановки или восстановления." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000081"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как избежать гонок при публикации immutable-снимка конфигурации между потоками?». Поэтому он не отвечает на текущую формулировку.", "Снимок полностью строят до публикации, не изменяют после неё и заменяют ссылку атомарно через Volatile.Write или Interlocked.Exchange. Читатели получают локальную копию ссылки через Volatile.Read и работают без блокировок. Важно, чтобы весь достижимый граф действительно был immutable, иначе безопасная публикация корня не устраняет внутренние гонки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000082"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему SafeHandle предпочтительнее собственного финализатора для native-ресурса?». Поэтому он не отвечает на текущую формулировку.", "SafeHandle инкапсулирует критический handle, корректно взаимодействует с GC и гарантирует освобождение даже при исключениях и сложной финализации. Собственный финализатор удлиняет жизнь объекта и легко содержит race или double-free. Управляемый wrapper обычно владеет SafeHandle и реализует Dispose без собственной небезопасной логики финализации." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000083"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему fire-and-forget Task часто приводит к потерянным ошибкам и повреждению lifetime?». Поэтому он не отвечает на текущую формулировку.", "Вызывающий код не наблюдает завершение и исключение, а захваченные scoped-сервисы могут быть уже освобождены. Задачу следует await-ить, передать управляемому background queue или зарегистрировать у компонента, который наблюдает результат и остановку. Если отделение намеренное, нужны собственный scope, logging, timeout и политика ошибок." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000092"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда reflection становится архитектурной или производительной проблемой и чем её заменить?». Поэтому он не отвечает на текущую формулировку.", "Reflection усложняет trimming/AOT, переносит ошибки в runtime и в горячих путях добавляет lookup, boxing и invocation overhead. Метаданные можно кэшировать, вызовы компилировать в delegates, а для сериализации, DI-регистрации и маппинга использовать source generators. Замена оправдана после измерений либо когда нужна статическая проверяемость и Native AOT." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000093"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Где generics устраняют boxing, а где boxing всё равно появляется?». Поэтому он не отвечает на текущую формулировку.", "Generic-код со значимым типом обычно работает без упаковки благодаря специализации runtime. Boxing возникает при приведении к object или интерфейсу, использовании негeneric API, некоторых вызовах constrained-методов и форматировании. Проверяют allocations профилировщиком; constraints и generic-интерфейсы помогают сохранить статический тип." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000094"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как безопасно кэшировать данные с помощью ConcurrentDictionary.GetOrAdd при дорогой фабрике?». Поэтому он не отвечает на текущую формулировку.", "Value factory может выполниться несколько раз параллельно, хотя в словарь попадёт одно значение, поэтому она не должна иметь необратимых side effects. Для единственного вычисления хранят Lazy<T> или Task<T> с подходящим режимом синхронизации и решают, удалять ли faulted/cancelled значение для повторной попытки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000101"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем Tiered Compilation, dynamic PGO и Native AOT меняют подход к оптимизации .NET-приложения?». Поэтому он не отвечает на текущую формулировку.", "Tiered compilation быстро запускает код и затем перекомпилирует горячие методы; dynamic PGO использует фактический профиль для специализации. Native AOT уменьшает startup и footprint, но ограничивает динамическую генерацию кода и reflection-сценарии. Поэтому оптимизируют по реальному режиму деплоя, прогревают benchmark и проверяют совместимость библиотек." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000103"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Для чего нужны in, ref readonly и scoped и какие риски они уменьшают?». Поэтому он не отвечает на текущую формулировку.", "in и ref readonly позволяют передавать или возвращать ссылку без права изменения, что может снизить копирование крупных struct. scoped ограничивает escape ссылки временем жизни текущего scope и помогает компилятору предотвращать висячие ссылки. Для маленьких struct косвенный доступ может быть не быстрее, поэтому выбор подтверждают benchmark." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000104"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем IAsyncEnumerable<T> полезен для потоковой обработки и какие обязанности он добавляет?». Поэтому он не отвечает на текущую формулировку.", "Он позволяет отдавать элементы по мере готовности без материализации всей коллекции и поддерживает естественный backpressure на уровне MoveNextAsync. Нужно передавать отмену через WithCancellation или EnumeratorCancellation, корректно освобождать enumerator и помнить, что ошибки могут возникнуть в середине перечисления. Источник не следует перечислять конкурентно без явного контракта." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000111"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему подписка на event может вызвать утечку памяти?». Поэтому он не отвечает на текущую формулировку.", "Publisher хранит сильную ссылку на delegate, а delegate — на subscriber, поэтому долгоживущий publisher удерживает подписчика. Нужно явно отписываться, возвращать IDisposable-токен подписки, привязывать время жизни объектов или применять weak-event только при понятной семантике. Анонимная lambda усложняет отписку, если её экземпляр не сохранён." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000112"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как спроектировать тип value object, чтобы он оставался корректным в многопоточном и доменном коде?». Поэтому он не отвечает на текущую формулировку.", "Value object делают неизменяемым, валидируют при создании и определяют равенство по всем значимым компонентам. Он не должен иметь отдельного жизненного цикла или изменяемой идентичности. Неизменяемость упрощает совместное использование между потоками, но вложенные коллекции тоже должны быть immutable или защищённо скопированы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000114"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как вы будете расследовать рост памяти в .NET-сервисе, не предполагая заранее утечку?». Поэтому он не отвечает на текущую формулировку.", "Сначала разделяют managed heap, native memory, working set и кэши, наблюдая тренд после полных GC. Затем сравнивают heap dumps, ищут доминирующие типы и цепочки удержания, проверяют event subscriptions, static roots, timers и незавершённые Tasks. Важно воспроизвести нагрузку и доказать удержание объектов, а не судить только по диспетчеру задач." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000121"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему исключения не подходят для обычного управления потоком в горячем коде?». Поэтому он не отвечает на текущую формулировку.", "Создание и обработка исключения существенно дороже обычной ветки и искажает telemetry, если ожидаемые ситуации выглядят как ошибки. Для вероятного неуспеха лучше Try-методы, Result или явный union. Исключение остаётся правильным для нарушения контракта и действительно исключительного состояния, особенно когда вызывающий уровень может восстановиться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000122"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое sync-over-async и почему .Result или .Wait опасны даже без SynchronizationContext?». Поэтому он не отвечает на текущую формулировку.", "Блокировка потока до завершения async-операции может вызвать классический deadlock при захваченном context, а на сервере — ThreadPool starvation и резкий рост latency. Исключения также оборачиваются иначе. Правильное решение — async all the way; синхронную границу оставляют только при контролируемом startup-коде и ясных ограничениях." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000123"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «В чём разница между IEnumerable<T> и IQueryable<T> и где проходит граница их безопасного использования?». Поэтому он не отвечает на текущую формулировку.", "IEnumerable<T> выполняет дальнейшие операции в памяти через LINQ to Objects. IQueryable<T> хранит expression tree, который провайдер переводит во внешний запрос, например SQL. IQueryable не стоит выпускать за границы слоя данных: это размывает ответственность, усложняет тестирование и позволяет вызывающему сформировать неэффективный запрос." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000132"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что реально дают nullable reference types и где остаются границы их гарантий?». Поэтому он не отвечает на текущую формулировку.", "NRT — статический анализ аннотаций, а не runtime-защита: он уменьшает число случайных null, но внешние данные, reflection, старые библиотеки и неверный оператор ! могут нарушить контракт. На границах всё равно нужна runtime-валидация. Аннотации следует согласовывать с доменной семантикой, а не отключать предупреждения массовыми подавлениями." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000133"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать retry для асинхронной операции, чтобы не усугубить отказ?». Поэтому он не отвечает на текущую формулировку.", "Повторяют только транзиентные и идемпотентные операции, используют ограниченное число попыток, exponential backoff с jitter и общий timeout. CancellationToken должен прекращать ожидание. Retry без лимита создаёт retry storm, поэтому его сочетают с circuit breaker, ограничением конкуренции и наблюдаемостью причин." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000134"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как работает async/await в C# и почему async-метод не обязательно создаёт новый поток?». Поэтому он не отвечает на текущую формулировку.", "Компилятор преобразует async-метод в конечный автомат. При незавершённой await-операции управление возвращается вызывающему коду, а продолжение планируется после завершения Task. Для I/O поток обычно не блокируется и новый поток не требуется; пул потоков нужен преимущественно для CPU-bound работы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000141"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие скрытые аллокации создают closures и как проверить, что оптимизация действительно нужна?». Поэтому он не отвечает на текущую формулировку.", "Lambda, захватывающая локальные переменные или this, обычно создаёт объект closure и delegate; в цикле это может стать заметным allocation rate. Помогают static lambda, передача state отдельным параметром и кэширование delegate. Но решение принимают по профилю или BenchmarkDotNet, потому что читаемость важнее микроскопической экономии вне горячего пути." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000143"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие проблемы создаёт DateTime.Now в распределённой системе?». Поэтому он не отвечает на текущую формулировку.", "Локальное время неоднозначно при переходах DST и зависит от timezone машины. Для событий и хранения обычно используют UTC через DateTimeOffset и внедряемый TimeProvider, а локализацию выполняют на границе отображения. Для измерения длительности нужен монотонный Stopwatch, потому что wall clock может корректироваться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000144"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда следует использовать record, class и struct?». Поэтому он не отвечает на текущую формулировку.", "Class подходит для объектов с идентичностью и изменяемым жизненным циклом. Record удобен для value-like моделей и DTO благодаря value equality и with-выражениям. Struct стоит применять для небольших неизменяемых значений, которые часто создаются и не требуют наследования; крупные структуры увеличивают стоимость копирования." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000151"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие ошибки возникают из-за deferred execution в LINQ?». Поэтому он не отвечает на текущую формулировку.", "Запрос выполняется при перечислении, поэтому повторное перечисление может повторить дорогой I/O или увидеть уже изменённое состояние. Возврат ленивой последовательности за пределы lifetime DbContext приводит к сбоям, а side effects внутри Select делают поведение неочевидным. Границу материализации выбирают явно и документируют одноразовые последовательности." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000152"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как безопасно использовать Random в конкурентном приложении и когда нужен криптографический генератор?». Поэтому он не отвечает на текущую формулировку.", "Для симуляций и некритичных значений используют Random.Shared, который безопасен для параллельного доступа. Токены, пароли, nonce и идентификаторы безопасности требуют RandomNumberGenerator. Seeded Random полезен для воспроизводимых тестов, но его предсказуемость делает его непригодным для защиты." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000154"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Объясните назначение Span<T> и Memory<T>. Какие ограничения есть у Span<T>?». Поэтому он не отвечает на текущую формулировку.", "Span<T> представляет непрерывный участок памяти без дополнительных аллокаций и может ссылаться на массив, stackalloc или unmanaged memory. Это ref struct, поэтому он не может храниться в heap-объекте, использоваться через await или yield. Memory<T> можно хранить в объектах и передавать через async-границы, получая Span при синхронной обработке." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000161"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как Task.WhenAll сообщает об ошибках и отмене нескольких операций?». Поэтому он не отвечает на текущую формулировку.", "Возвращаемый Task завершается после всех операций; при ошибках он Faulted, а Exception содержит aggregate внутренних ошибок, хотя await обычно пробрасывает одну. Остальные ошибки нужно анализировать через сам Task. Отмена не прекращает уже запущенную работу автоматически: всем операциям передают общий token и отдельно решают политику частичного результата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000162"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как правильно повторно выбросить исключение и когда полезны exception filters?». Поэтому он не отвечает на текущую формулировку.", "Внутри catch оператор throw сохраняет исходный stack trace, а throw ex его повреждает. Filter when позволяет классифицировать исключение без входа в catch и не меняет исходный стек; в нём не должно быть side effects. Перехватывают исключение только если добавляют контекст, выполняют восстановление или переводят его на осмысленную границу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000163"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как правильно реализовать отмену длительной операции с помощью CancellationToken?». Поэтому он не отвечает на текущую формулировку.", "Токен передают по всей цепочке вызовов и регулярно проверяют через ThrowIfCancellationRequested либо прокидывают в поддерживающие его API. Владелец CancellationTokenSource отвечает за отмену и освобождение ресурса. OperationCanceledException не следует превращать в обычную ошибку: она отражает ожидаемое завершение по запросу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000172"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как спроектировать ограниченный асинхронный pipeline с backpressure?». Поэтому он не отвечает на текущую формулировку.", "Используют bounded Channel или очередь с ограниченной ёмкостью, чтобы быстрый producer ждал либо применял явную политику drop. Число consumers ограничивают по характеру работы, ошибки и завершение канала распространяют явно, CancellationToken проходит по всей цепочке. Метрики глубины очереди и времени ожидания показывают, где находится bottleneck." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000173"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать между ArrayPool<T>, MemoryPool<T> и обычным массивом?». Поэтому он не отвечает на текущую формулировку.", "Обычный массив проще и безопаснее для долгоживущих данных. ArrayPool снижает давление на GC для частых временных буферов, но арендованный массив может быть больше запрошенного, содержит старые данные и обязан возвращаться в finally; чувствительные данные очищают. MemoryPool удобен для ownership-модели и pipelines, особенно с нестандартной памятью." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000174"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как устроены поколения GC, Server GC и Workstation GC, и по каким метрикам вы будете искать причину длинных пауз?». Поэтому он не отвечает на текущую формулировку.", "Поколения 0–2 используют гипотезу о короткой жизни большинства объектов; крупные объекты попадают в LOH. Server GC создаёт heap и поток сборки на логический процессор и ориентирован на throughput, Workstation — на отзывчивость. Начинать нужно с allocation rate, % Time in GC, pause duration, размера поколений и LOH, затем подтверждать причину через dotnet-counters, trace или dump." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000181"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему SafeHandle предпочтительнее собственного финализатора для native-ресурса?». Поэтому он не отвечает на текущую формулировку.", "SafeHandle инкапсулирует критический handle, корректно взаимодействует с GC и гарантирует освобождение даже при исключениях и сложной финализации. Собственный финализатор удлиняет жизнь объекта и легко содержит race или double-free. Управляемый wrapper обычно владеет SafeHandle и реализует Dispose без собственной небезопасной логики финализации." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000183"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое false sharing и как оно проявляется в .NET?». Поэтому он не отвечает на текущую формулировку.", "Независимые значения в одной cache line заставляют ядра постоянно инвалидировать кэш друг друга, поэтому масштабирование ухудшается без логической блокировки. Это видно в высококонкурентных счётчиках и массивах состояния. Помогают разбиение счётчиков, локальная агрегация и иногда padding, но подтверждать причину нужно аппаратными метриками и benchmark." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000184"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему длительное pinning управляемой памяти опасно и когда без него всё же не обойтись?». Поэтому он не отвечает на текущую формулировку.", "Pinned-объект нельзя перемещать при compaction, поэтому множество долгоживущих закреплений фрагментирует heap и повышает стоимость GC. Pinning оправдан на короткой границе с native API или I/O; для долгих буферов лучше использовать специализированные пулы, pinned object heap либо unmanaged memory и явно контролировать время жизни." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000191"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Где generics устраняют boxing, а где boxing всё равно появляется?». Поэтому он не отвечает на текущую формулировку.", "Generic-код со значимым типом обычно работает без упаковки благодаря специализации runtime. Boxing возникает при приведении к object или интерфейсу, использовании негeneric API, некоторых вызовах constrained-методов и форматировании. Проверяют allocations профилировщиком; constraints и generic-интерфейсы помогают сохранить статический тип." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000192"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как организовать graceful shutdown фоновых задач в Generic Host?». Поэтому он не отвечает на текущую формулировку.", "BackgroundService должен уважать stoppingToken, не запускать fire-and-forget работу без учёта и завершать приём новых задач до дренирования текущих. На остановке учитывают host shutdown timeout, корректно закрывают каналы и освобождают ресурсы. Необработанная ошибка фоновой задачи должна быть наблюдаемой и иметь явную политику остановки или восстановления." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000194"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как диагностировать ThreadPool starvation в ASP.NET Core и чем он отличается от высокой загрузки CPU?». Поэтому он не отвечает на текущую формулировку.", "При starvation запросы ждут свободный worker, latency растёт, а CPU может оставаться умеренным; типичные причины — sync-over-async, блокирующие I/O и долгие locks. Проверяют очередь ThreadPool, число потоков, request latency и stacks через dotnet-counters, dotnet-stack или trace. Исправление — асинхронность по всей цепочке, устранение блокировок и ограничение параллелизма, а не бездумное увеличение MinThreads." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000201"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Для чего нужны in, ref readonly и scoped и какие риски они уменьшают?». Поэтому он не отвечает на текущую формулировку.", "in и ref readonly позволяют передавать или возвращать ссылку без права изменения, что может снизить копирование крупных struct. scoped ограничивает escape ссылки временем жизни текущего scope и помогает компилятору предотвращать висячие ссылки. Для маленьких struct косвенный доступ может быть не быстрее, поэтому выбор подтверждают benchmark." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000202"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему fire-and-forget Task часто приводит к потерянным ошибкам и повреждению lifetime?». Поэтому он не отвечает на текущую формулировку.", "Вызывающий код не наблюдает завершение и исключение, а захваченные scoped-сервисы могут быть уже освобождены. Задачу следует await-ить, передать управляемому background queue или зарегистрировать у компонента, который наблюдает результат и остановку. Если отделение намеренное, нужны собственный scope, logging, timeout и политика ошибок." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000203"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда ValueTask оправдан, а когда он только усложняет код?». Поэтому он не отвечает на текущую формулировку.", "ValueTask полезен в очень горячем API, которое часто завершается синхронно и где измерения показывают значимые аллокации Task. Его нельзя бездумно await-ить несколько раз, хранить или комбинировать как обычный Task; часто требуется AsTask. По умолчанию предпочтителен Task, а ValueTask вводят только после профилирования и с ясным контрактом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000212"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как спроектировать тип value object, чтобы он оставался корректным в многопоточном и доменном коде?». Поэтому он не отвечает на текущую формулировку.", "Value object делают неизменяемым, валидируют при создании и определяют равенство по всем значимым компонентам. Он не должен иметь отдельного жизненного цикла или изменяемой идентичности. Неизменяемость упрощает совместное использование между потоками, но вложенные коллекции тоже должны быть immutable или защищённо скопированы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000213"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как безопасно кэшировать данные с помощью ConcurrentDictionary.GetOrAdd при дорогой фабрике?». Поэтому он не отвечает на текущую формулировку.", "Value factory может выполниться несколько раз параллельно, хотя в словарь попадёт одно значение, поэтому она не должна иметь необратимых side effects. Для единственного вычисления хранят Lazy<T> или Task<T> с подходящим режимом синхронизации и решают, удалять ли faulted/cancelled значение для повторной попытки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000214"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Объясните ковариантность и контравариантность generic-интерфейсов на практическом примере.». Поэтому он не отвечает на текущую формулировку.", "Ковариантный out-параметр позволяет использовать источник более конкретного типа как источник базового, например IEnumerable<Dog> как IEnumerable<Animal>. Контравариантный in-параметр позволяет обработчику базового типа обслуживать конкретный, например IComparer<Animal> для Dog. Вариантность безопасна только для ссылочных типов и ограничивает позиции чтения и записи параметра." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000221"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое sync-over-async и почему .Result или .Wait опасны даже без SynchronizationContext?». Поэтому он не отвечает на текущую формулировку.", "Блокировка потока до завершения async-операции может вызвать классический deadlock при захваченном context, а на сервере — ThreadPool starvation и резкий рост latency. Исключения также оборачиваются иначе. Правильное решение — async all the way; синхронную границу оставляют только при контролируемом startup-коде и ясных ограничениях." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000223"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем IAsyncEnumerable<T> полезен для потоковой обработки и какие обязанности он добавляет?». Поэтому он не отвечает на текущую формулировку.", "Он позволяет отдавать элементы по мере готовности без материализации всей коллекции и поддерживает естественный backpressure на уровне MoveNextAsync. Нужно передавать отмену через WithCancellation или EnumeratorCancellation, корректно освобождать enumerator и помнить, что ошибки могут возникнуть в середине перечисления. Источник не следует перечислять конкурентно без явного контракта." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000224"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие требования связывают Equals, GetHashCode и использование объекта как ключа Dictionary?». Поэтому он не отвечает на текущую формулировку.", "Если Equals возвращает true, hash code обязан совпадать; обратное не требуется. Поля, участвующие в равенстве и hash code, нельзя менять, пока объект служит ключом, иначе запись станет логически недоступной. Для value object обычно задают структурное равенство, а entity сравнивают по устойчивой идентичности с осторожностью до её назначения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000231"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать retry для асинхронной операции, чтобы не усугубить отказ?». Поэтому он не отвечает на текущую формулировку.", "Повторяют только транзиентные и идемпотентные операции, используют ограниченное число попыток, exponential backoff с jitter и общий timeout. CancellationToken должен прекращать ожидание. Retry без лимита создаёт retry storm, поэтому его сочетают с circuit breaker, ограничением конкуренции и наблюдаемостью причин." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000232"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как вы будете расследовать рост памяти в .NET-сервисе, не предполагая заранее утечку?». Поэтому он не отвечает на текущую формулировку.", "Сначала разделяют managed heap, native memory, working set и кэши, наблюдая тренд после полных GC. Затем сравнивают heap dumps, ищут доминирующие типы и цепочки удержания, проверяют event subscriptions, static roots, timers и незавершённые Tasks. Важно воспроизвести нагрузку и доказать удержание объектов, а не судить только по диспетчеру задач." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000234"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как правильно проектировать IDisposable и IAsyncDisposable для класса с несколькими ресурсами?». Поэтому он не отвечает на текущую формулировку.", "Класс должен освобождать только ресурсы, которыми владеет, быть устойчивым к повторному Dispose и не выполнять работу после освобождения. IAsyncDisposable нужен, когда корректное закрытие требует async I/O; комбинированный тип обычно реализует оба пути и подавляет финализацию. Финализатор нужен только при прямом владении unmanaged-ресурсом, предпочтительно через SafeHandle." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000241"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие проблемы создаёт DateTime.Now в распределённой системе?». Поэтому он не отвечает на текущую формулировку.", "Локальное время неоднозначно при переходах DST и зависит от timezone машины. Для событий и хранения обычно используют UTC через DateTimeOffset и внедряемый TimeProvider, а локализацию выполняют на границе отображения. Для измерения длительности нужен монотонный Stopwatch, потому что wall clock может корректироваться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000242"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «В чём разница между IEnumerable<T> и IQueryable<T> и где проходит граница их безопасного использования?». Поэтому он не отвечает на текущую формулировку.", "IEnumerable<T> выполняет дальнейшие операции в памяти через LINQ to Objects. IQueryable<T> хранит expression tree, который провайдер переводит во внешний запрос, например SQL. IQueryable не стоит выпускать за границы слоя данных: это размывает ответственность, усложняет тестирование и позволяет вызывающему сформировать неэффективный запрос." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000243"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать между lock, SemaphoreSlim, ReaderWriterLockSlim и Channel<T>?». Поэтому он не отвечает на текущую формулировку.", "lock подходит для короткой синхронной критической секции без await. SemaphoreSlim позволяет асинхронно ограничивать конкуренцию, ReaderWriterLockSlim полезен лишь при измеренном преобладании чтений и достаточной длительности операций. Channel<T> часто лучше общей блокировки, когда задачу можно представить как очередь с одним или несколькими потребителями и backpressure." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000252"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как безопасно использовать Random в конкурентном приложении и когда нужен криптографический генератор?». Поэтому он не отвечает на текущую формулировку.", "Для симуляций и некритичных значений используют Random.Shared, который безопасен для параллельного доступа. Токены, пароли, nonce и идентификаторы безопасности требуют RandomNumberGenerator. Seeded Random полезен для воспроизводимых тестов, но его предсказуемость делает его непригодным для защиты." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000253"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как работает async/await в C# и почему async-метод не обязательно создаёт новый поток?». Поэтому он не отвечает на текущую формулировку.", "Компилятор преобразует async-метод в конечный автомат. При незавершённой await-операции управление возвращается вызывающему коду, а продолжение планируется после завершения Task. Для I/O поток обычно не блокируется и новый поток не требуется; пул потоков нужен преимущественно для CPU-bound работы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000254"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что гарантирует volatile, а что требует Interlocked или lock?». Поэтому он не отвечает на текущую формулировку.", "volatile задаёт семантику чтения и записи с барьерами видимости, но не делает составные операции вроде increment атомарными и не защищает инвариант нескольких полей. Interlocked подходит для атомарных операций над отдельным значением. Если переход состояния затрагивает несколько значений или требует проверки-изменения, нужен lock либо другая синхронизация." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000261"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как правильно повторно выбросить исключение и когда полезны exception filters?». Поэтому он не отвечает на текущую формулировку.", "Внутри catch оператор throw сохраняет исходный stack trace, а throw ex его повреждает. Filter when позволяет классифицировать исключение без входа в catch и не меняет исходный стек; в нём не должно быть side effects. Перехватывают исключение только если добавляют контекст, выполняют восстановление или переводят его на осмысленную границу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000263"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда следует использовать record, class и struct?». Поэтому он не отвечает на текущую формулировку.", "Class подходит для объектов с идентичностью и изменяемым жизненным циклом. Record удобен для value-like моделей и DTO благодаря value equality и with-выражениям. Struct стоит применять для небольших неизменяемых значений, которые часто создаются и не требуют наследования; крупные структуры увеличивают стоимость копирования." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000264"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как избежать гонок при публикации immutable-снимка конфигурации между потоками?». Поэтому он не отвечает на текущую формулировку.", "Снимок полностью строят до публикации, не изменяют после неё и заменяют ссылку атомарно через Volatile.Write или Interlocked.Exchange. Читатели получают локальную копию ссылки через Volatile.Read и работают без блокировок. Важно, чтобы весь достижимый граф действительно был immutable, иначе безопасная публикация корня не устраняет внутренние гонки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000271"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать между ArrayPool<T>, MemoryPool<T> и обычным массивом?». Поэтому он не отвечает на текущую формулировку.", "Обычный массив проще и безопаснее для долгоживущих данных. ArrayPool снижает давление на GC для частых временных буферов, но арендованный массив может быть больше запрошенного, содержит старые данные и обязан возвращаться в finally; чувствительные данные очищают. MemoryPool удобен для ownership-модели и pipelines, особенно с нестандартной памятью." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000272"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Объясните назначение Span<T> и Memory<T>. Какие ограничения есть у Span<T>?». Поэтому он не отвечает на текущую формулировку.", "Span<T> представляет непрерывный участок памяти без дополнительных аллокаций и может ссылаться на массив, stackalloc или unmanaged memory. Это ref struct, поэтому он не может храниться в heap-объекте, использоваться через await или yield. Memory<T> можно хранить в объектах и передавать через async-границы, получая Span при синхронной обработке." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000274"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда reflection становится архитектурной или производительной проблемой и чем её заменить?». Поэтому он не отвечает на текущую формулировку.", "Reflection усложняет trimming/AOT, переносит ошибки в runtime и в горячих путях добавляет lookup, boxing и invocation overhead. Метаданные можно кэшировать, вызовы компилировать в delegates, а для сериализации, DI-регистрации и маппинга использовать source generators. Замена оправдана после измерений либо когда нужна статическая проверяемость и Native AOT." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000281"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое false sharing и как оно проявляется в .NET?». Поэтому он не отвечает на текущую формулировку.", "Независимые значения в одной cache line заставляют ядра постоянно инвалидировать кэш друг друга, поэтому масштабирование ухудшается без логической блокировки. Это видно в высококонкурентных счётчиках и массивах состояния. Помогают разбиение счётчиков, локальная агрегация и иногда padding, но подтверждать причину нужно аппаратными метриками и benchmark." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000282"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как правильно реализовать отмену длительной операции с помощью CancellationToken?». Поэтому он не отвечает на текущую формулировку.", "Токен передают по всей цепочке вызовов и регулярно проверяют через ThrowIfCancellationRequested либо прокидывают в поддерживающие его API. Владелец CancellationTokenSource отвечает за отмену и освобождение ресурса. OperationCanceledException не следует превращать в обычную ошибку: она отражает ожидаемое завершение по запросу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000283"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем Tiered Compilation, dynamic PGO и Native AOT меняют подход к оптимизации .NET-приложения?». Поэтому он не отвечает на текущую формулировку.", "Tiered compilation быстро запускает код и затем перекомпилирует горячие методы; dynamic PGO использует фактический профиль для специализации. Native AOT уменьшает startup и footprint, но ограничивает динамическую генерацию кода и reflection-сценарии. Поэтому оптимизируют по реальному режиму деплоя, прогревают benchmark и проверяют совместимость библиотек." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000292"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как организовать graceful shutdown фоновых задач в Generic Host?». Поэтому он не отвечает на текущую формулировку.", "BackgroundService должен уважать stoppingToken, не запускать fire-and-forget работу без учёта и завершать приём новых задач до дренирования текущих. На остановке учитывают host shutdown timeout, корректно закрывают каналы и освобождают ресурсы. Необработанная ошибка фоновой задачи должна быть наблюдаемой и иметь явную политику остановки или восстановления." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000293"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как устроены поколения GC, Server GC и Workstation GC, и по каким метрикам вы будете искать причину длинных пауз?». Поэтому он не отвечает на текущую формулировку.", "Поколения 0–2 используют гипотезу о короткой жизни большинства объектов; крупные объекты попадают в LOH. Server GC создаёт heap и поток сборки на логический процессор и ориентирован на throughput, Workstation — на отзывчивость. Начинать нужно с allocation rate, % Time in GC, pause duration, размера поколений и LOH, затем подтверждать причину через dotnet-counters, trace или dump." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000294"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему подписка на event может вызвать утечку памяти?». Поэтому он не отвечает на текущую формулировку.", "Publisher хранит сильную ссылку на delegate, а delegate — на subscriber, поэтому долгоживущий publisher удерживает подписчика. Нужно явно отписываться, возвращать IDisposable-токен подписки, привязывать время жизни объектов или применять weak-event только при понятной семантике. Анонимная lambda усложняет отписку, если её экземпляр не сохранён." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000301"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему fire-and-forget Task часто приводит к потерянным ошибкам и повреждению lifetime?». Поэтому он не отвечает на текущую формулировку.", "Вызывающий код не наблюдает завершение и исключение, а захваченные scoped-сервисы могут быть уже освобождены. Задачу следует await-ить, передать управляемому background queue или зарегистрировать у компонента, который наблюдает результат и остановку. Если отделение намеренное, нужны собственный scope, logging, timeout и политика ошибок." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000303"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему длительное pinning управляемой памяти опасно и когда без него всё же не обойтись?». Поэтому он не отвечает на текущую формулировку.", "Pinned-объект нельзя перемещать при compaction, поэтому множество долгоживущих закреплений фрагментирует heap и повышает стоимость GC. Pinning оправдан на короткой границе с native API или I/O; для долгих буферов лучше использовать специализированные пулы, pinned object heap либо unmanaged memory и явно контролировать время жизни." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000304"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему исключения не подходят для обычного управления потоком в горячем коде?». Поэтому он не отвечает на текущую формулировку.", "Создание и обработка исключения существенно дороже обычной ветки и искажает telemetry, если ожидаемые ситуации выглядят как ошибки. Для вероятного неуспеха лучше Try-методы, Result или явный union. Исключение остаётся правильным для нарушения контракта и действительно исключительного состояния, особенно когда вызывающий уровень может восстановиться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000311"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как безопасно кэшировать данные с помощью ConcurrentDictionary.GetOrAdd при дорогой фабрике?». Поэтому он не отвечает на текущую формулировку.", "Value factory может выполниться несколько раз параллельно, хотя в словарь попадёт одно значение, поэтому она не должна иметь необратимых side effects. Для единственного вычисления хранят Lazy<T> или Task<T> с подходящим режимом синхронизации и решают, удалять ли faulted/cancelled значение для повторной попытки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000312"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как диагностировать ThreadPool starvation в ASP.NET Core и чем он отличается от высокой загрузки CPU?». Поэтому он не отвечает на текущую формулировку.", "При starvation запросы ждут свободный worker, latency растёт, а CPU может оставаться умеренным; типичные причины — sync-over-async, блокирующие I/O и долгие locks. Проверяют очередь ThreadPool, число потоков, request latency и stacks через dotnet-counters, dotnet-stack или trace. Исправление — асинхронность по всей цепочке, устранение блокировок и ограничение параллелизма, а не бездумное увеличение MinThreads." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000314"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что реально дают nullable reference types и где остаются границы их гарантий?». Поэтому он не отвечает на текущую формулировку.", "NRT — статический анализ аннотаций, а не runtime-защита: он уменьшает число случайных null, но внешние данные, reflection, старые библиотеки и неверный оператор ! могут нарушить контракт. На границах всё равно нужна runtime-валидация. Аннотации следует согласовывать с доменной семантикой, а не отключать предупреждения массовыми подавлениями." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000321"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем IAsyncEnumerable<T> полезен для потоковой обработки и какие обязанности он добавляет?». Поэтому он не отвечает на текущую формулировку.", "Он позволяет отдавать элементы по мере готовности без материализации всей коллекции и поддерживает естественный backpressure на уровне MoveNextAsync. Нужно передавать отмену через WithCancellation или EnumeratorCancellation, корректно освобождать enumerator и помнить, что ошибки могут возникнуть в середине перечисления. Источник не следует перечислять конкурентно без явного контракта." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000322"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда ValueTask оправдан, а когда он только усложняет код?». Поэтому он не отвечает на текущую формулировку.", "ValueTask полезен в очень горячем API, которое часто завершается синхронно и где измерения показывают значимые аллокации Task. Его нельзя бездумно await-ить несколько раз, хранить или комбинировать как обычный Task; часто требуется AsTask. По умолчанию предпочтителен Task, а ValueTask вводят только после профилирования и с ясным контрактом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000323"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие скрытые аллокации создают closures и как проверить, что оптимизация действительно нужна?». Поэтому он не отвечает на текущую формулировку.", "Lambda, захватывающая локальные переменные или this, обычно создаёт объект closure и delegate; в цикле это может стать заметным allocation rate. Помогают static lambda, передача state отдельным параметром и кэширование delegate. Но решение принимают по профилю или BenchmarkDotNet, потому что читаемость важнее микроскопической экономии вне горячего пути." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000332"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как вы будете расследовать рост памяти в .NET-сервисе, не предполагая заранее утечку?». Поэтому он не отвечает на текущую формулировку.", "Сначала разделяют managed heap, native memory, working set и кэши, наблюдая тренд после полных GC. Затем сравнивают heap dumps, ищут доминирующие типы и цепочки удержания, проверяют event subscriptions, static roots, timers и незавершённые Tasks. Важно воспроизвести нагрузку и доказать удержание объектов, а не судить только по диспетчеру задач." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000333"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Объясните ковариантность и контравариантность generic-интерфейсов на практическом примере.». Поэтому он не отвечает на текущую формулировку.", "Ковариантный out-параметр позволяет использовать источник более конкретного типа как источник базового, например IEnumerable<Dog> как IEnumerable<Animal>. Контравариантный in-параметр позволяет обработчику базового типа обслуживать конкретный, например IComparer<Animal> для Dog. Вариантность безопасна только для ссылочных типов и ограничивает позиции чтения и записи параметра." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000334"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие ошибки возникают из-за deferred execution в LINQ?». Поэтому он не отвечает на текущую формулировку.", "Запрос выполняется при перечислении, поэтому повторное перечисление может повторить дорогой I/O или увидеть уже изменённое состояние. Возврат ленивой последовательности за пределы lifetime DbContext приводит к сбоям, а side effects внутри Select делают поведение неочевидным. Границу материализации выбирают явно и документируют одноразовые последовательности." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000341"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «В чём разница между IEnumerable<T> и IQueryable<T> и где проходит граница их безопасного использования?». Поэтому он не отвечает на текущую формулировку.", "IEnumerable<T> выполняет дальнейшие операции в памяти через LINQ to Objects. IQueryable<T> хранит expression tree, который провайдер переводит во внешний запрос, например SQL. IQueryable не стоит выпускать за границы слоя данных: это размывает ответственность, усложняет тестирование и позволяет вызывающему сформировать неэффективный запрос." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000343"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие требования связывают Equals, GetHashCode и использование объекта как ключа Dictionary?». Поэтому он не отвечает на текущую формулировку.", "Если Equals возвращает true, hash code обязан совпадать; обратное не требуется. Поля, участвующие в равенстве и hash code, нельзя менять, пока объект служит ключом, иначе запись станет логически недоступной. Для value object обычно задают структурное равенство, а entity сравнивают по устойчивой идентичности с осторожностью до её назначения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000344"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как Task.WhenAll сообщает об ошибках и отмене нескольких операций?». Поэтому он не отвечает на текущую формулировку.", "Возвращаемый Task завершается после всех операций; при ошибках он Faulted, а Exception содержит aggregate внутренних ошибок, хотя await обычно пробрасывает одну. Остальные ошибки нужно анализировать через сам Task. Отмена не прекращает уже запущенную работу автоматически: всем операциям передают общий token и отдельно решают политику частичного результата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000351"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как работает async/await в C# и почему async-метод не обязательно создаёт новый поток?». Поэтому он не отвечает на текущую формулировку.", "Компилятор преобразует async-метод в конечный автомат. При незавершённой await-операции управление возвращается вызывающему коду, а продолжение планируется после завершения Task. Для I/O поток обычно не блокируется и новый поток не требуется; пул потоков нужен преимущественно для CPU-bound работы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000352"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как правильно проектировать IDisposable и IAsyncDisposable для класса с несколькими ресурсами?». Поэтому он не отвечает на текущую формулировку.", "Класс должен освобождать только ресурсы, которыми владеет, быть устойчивым к повторному Dispose и не выполнять работу после освобождения. IAsyncDisposable нужен, когда корректное закрытие требует async I/O; комбинированный тип обычно реализует оба пути и подавляет финализацию. Финализатор нужен только при прямом владении unmanaged-ресурсом, предпочтительно через SafeHandle." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000354"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как спроектировать ограниченный асинхронный pipeline с backpressure?». Поэтому он не отвечает на текущую формулировку.", "Используют bounded Channel или очередь с ограниченной ёмкостью, чтобы быстрый producer ждал либо применял явную политику drop. Число consumers ограничивают по характеру работы, ошибки и завершение канала распространяют явно, CancellationToken проходит по всей цепочке. Метрики глубины очереди и времени ожидания показывают, где находится bottleneck." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000361"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда следует использовать record, class и struct?». Поэтому он не отвечает на текущую формулировку.", "Class подходит для объектов с идентичностью и изменяемым жизненным циклом. Record удобен для value-like моделей и DTO благодаря value equality и with-выражениям. Struct стоит применять для небольших неизменяемых значений, которые часто создаются и не требуют наследования; крупные структуры увеличивают стоимость копирования." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000362"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать между lock, SemaphoreSlim, ReaderWriterLockSlim и Channel<T>?». Поэтому он не отвечает на текущую формулировку.", "lock подходит для короткой синхронной критической секции без await. SemaphoreSlim позволяет асинхронно ограничивать конкуренцию, ReaderWriterLockSlim полезен лишь при измеренном преобладании чтений и достаточной длительности операций. Channel<T> часто лучше общей блокировки, когда задачу можно представить как очередь с одним или несколькими потребителями и backpressure." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000363"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему SafeHandle предпочтительнее собственного финализатора для native-ресурса?». Поэтому он не отвечает на текущую формулировку.", "SafeHandle инкапсулирует критический handle, корректно взаимодействует с GC и гарантирует освобождение даже при исключениях и сложной финализации. Собственный финализатор удлиняет жизнь объекта и легко содержит race или double-free. Управляемый wrapper обычно владеет SafeHandle и реализует Dispose без собственной небезопасной логики финализации." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000372"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Объясните назначение Span<T> и Memory<T>. Какие ограничения есть у Span<T>?». Поэтому он не отвечает на текущую формулировку.", "Span<T> представляет непрерывный участок памяти без дополнительных аллокаций и может ссылаться на массив, stackalloc или unmanaged memory. Это ref struct, поэтому он не может храниться в heap-объекте, использоваться через await или yield. Memory<T> можно хранить в объектах и передавать через async-границы, получая Span при синхронной обработке." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000373"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что гарантирует volatile, а что требует Interlocked или lock?». Поэтому он не отвечает на текущую формулировку.", "volatile задаёт семантику чтения и записи с барьерами видимости, но не делает составные операции вроде increment атомарными и не защищает инвариант нескольких полей. Interlocked подходит для атомарных операций над отдельным значением. Если переход состояния затрагивает несколько значений или требует проверки-изменения, нужен lock либо другая синхронизация." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000374"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Где generics устраняют boxing, а где boxing всё равно появляется?». Поэтому он не отвечает на текущую формулировку.", "Generic-код со значимым типом обычно работает без упаковки благодаря специализации runtime. Boxing возникает при приведении к object или интерфейсу, использовании негeneric API, некоторых вызовах constrained-методов и форматировании. Проверяют allocations профилировщиком; constraints и generic-интерфейсы помогают сохранить статический тип." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000381"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как правильно реализовать отмену длительной операции с помощью CancellationToken?». Поэтому он не отвечает на текущую формулировку.", "Токен передают по всей цепочке вызовов и регулярно проверяют через ThrowIfCancellationRequested либо прокидывают в поддерживающие его API. Владелец CancellationTokenSource отвечает за отмену и освобождение ресурса. OperationCanceledException не следует превращать в обычную ошибку: она отражает ожидаемое завершение по запросу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000383"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как избежать гонок при публикации immutable-снимка конфигурации между потоками?». Поэтому он не отвечает на текущую формулировку.", "Снимок полностью строят до публикации, не изменяют после неё и заменяют ссылку атомарно через Volatile.Write или Interlocked.Exchange. Читатели получают локальную копию ссылки через Volatile.Read и работают без блокировок. Важно, чтобы весь достижимый граф действительно был immutable, иначе безопасная публикация корня не устраняет внутренние гонки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000384"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Для чего нужны in, ref readonly и scoped и какие риски они уменьшают?». Поэтому он не отвечает на текущую формулировку.", "in и ref readonly позволяют передавать или возвращать ссылку без права изменения, что может снизить копирование крупных struct. scoped ограничивает escape ссылки временем жизни текущего scope и помогает компилятору предотвращать висячие ссылки. Для маленьких struct косвенный доступ может быть не быстрее, поэтому выбор подтверждают benchmark." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000391"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как устроены поколения GC, Server GC и Workstation GC, и по каким метрикам вы будете искать причину длинных пауз?». Поэтому он не отвечает на текущую формулировку.", "Поколения 0–2 используют гипотезу о короткой жизни большинства объектов; крупные объекты попадают в LOH. Server GC создаёт heap и поток сборки на логический процессор и ориентирован на throughput, Workstation — на отзывчивость. Начинать нужно с allocation rate, % Time in GC, pause duration, размера поколений и LOH, затем подтверждать причину через dotnet-counters, trace или dump." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000392"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда reflection становится архитектурной или производительной проблемой и чем её заменить?». Поэтому он не отвечает на текущую формулировку.", "Reflection усложняет trimming/AOT, переносит ошибки в runtime и в горячих путях добавляет lookup, boxing и invocation overhead. Метаданные можно кэшировать, вызовы компилировать в delegates, а для сериализации, DI-регистрации и маппинга использовать source generators. Замена оправдана после измерений либо когда нужна статическая проверяемость и Native AOT." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000394"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как спроектировать тип value object, чтобы он оставался корректным в многопоточном и доменном коде?». Поэтому он не отвечает на текущую формулировку.", "Value object делают неизменяемым, валидируют при создании и определяют равенство по всем значимым компонентам. Он не должен иметь отдельного жизненного цикла или изменяемой идентичности. Неизменяемость упрощает совместное использование между потоками, но вложенные коллекции тоже должны быть immutable или защищённо скопированы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000401"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему длительное pinning управляемой памяти опасно и когда без него всё же не обойтись?». Поэтому он не отвечает на текущую формулировку.", "Pinned-объект нельзя перемещать при compaction, поэтому множество долгоживущих закреплений фрагментирует heap и повышает стоимость GC. Pinning оправдан на короткой границе с native API или I/O; для долгих буферов лучше использовать специализированные пулы, pinned object heap либо unmanaged memory и явно контролировать время жизни." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000402"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем Tiered Compilation, dynamic PGO и Native AOT меняют подход к оптимизации .NET-приложения?». Поэтому он не отвечает на текущую формулировку.", "Tiered compilation быстро запускает код и затем перекомпилирует горячие методы; dynamic PGO использует фактический профиль для специализации. Native AOT уменьшает startup и footprint, но ограничивает динамическую генерацию кода и reflection-сценарии. Поэтому оптимизируют по реальному режиму деплоя, прогревают benchmark и проверяют совместимость библиотек." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000403"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое sync-over-async и почему .Result или .Wait опасны даже без SynchronizationContext?». Поэтому он не отвечает на текущую формулировку.", "Блокировка потока до завершения async-операции может вызвать классический deadlock при захваченном context, а на сервере — ThreadPool starvation и резкий рост latency. Исключения также оборачиваются иначе. Правильное решение — async all the way; синхронную границу оставляют только при контролируемом startup-коде и ясных ограничениях." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000012"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что даёт DbContext pooling и какие данные нельзя оставлять в pooled context?». Поэтому он не отвечает на текущую формулировку.", "Pooling переиспользует экземпляры DbContext и уменьшает стоимость инициализации, но OnConfiguring обычно выполняется один раз. В context нельзя хранить request-specific состояние, tenant id или изменяемые флаги без гарантированного сброса. Пул не делает DbContext потокобезопасным и не заменяет pooling соединений драйвера." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000013"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие компромиссы у TPH, TPT и TPC наследования?». Поэтому он не отвечает на текущую формулировку.", "TPH хранит иерархию в одной таблице, обычно быстрее читает, но имеет nullable-столбцы и широкий ряд. TPT нормализует типы, однако сложные запросы требуют множества joins. TPC дублирует базовые столбцы и хорошо читает конкретные типы, но усложняет общие ключи и изменения схемы. Выбор подтверждают реальными запросами." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000014"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что происходит, когда часть LINQ-выражения не переводится в SQL?». Поэтому он не отвечает на текущую формулировку.", "Современный EF обычно выбрасывает исключение вне верхней client projection, чтобы не загрузить таблицу незаметно. Нужно переписать выражение в поддерживаемую форму, вынести вычисление после узкой материализации или добавить mapping database function. AsEnumerable ставят только после явного ограничения данных." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000021"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда compiled query имеет смысл и почему она не исправит медленный SQL?». Поэтому он не отвечает на текущую формулировку.", "Compiled query уменьшает overhead анализа expression tree и поиска в query cache в очень горячем повторяющемся запросе одной формы. Она не меняет план базы, индексы, число строк или network latency. Сначала оптимизируют SQL и roundtrips, затем benchmark показывает, значима ли доля самого EF." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000023"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как избежать случайной перезаписи полей при disconnected update из API?». Поэтому он не отвечает на текущую формулировку.", "Не следует принимать entity целиком и помечать её Modified. Загружают агрегат, применяют валидированную команду через доменные методы и сохраняют изменённые поля; для patch явно перечисляют разрешённые изменения. Concurrency token защищает от lost update, а DTO отделяет контракт от persistence-модели." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000024"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать read-only запрос с большим графом без materialization доменных entities?». Поэтому он не отвечает на текущую формулировку.", "Проецируют сразу в DTO только нужные поля, применяют фильтр и пагинацию до materialization, используют AsNoTracking и избегают Include, если Select уже выражает форму. Это уменьшает данные, ChangeTracker и coupling. Сгенерированный SQL и число roundtrips всё равно проверяют." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000031"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как форма LINQ-выражения влияет на query cache и план-кэш базы?». Поэтому он не отвечает на текущую формулировку.", "Константы, динамически встроенные в expression tree, создают новые формы запросов и могут загрязнять кэши EF и БД. Значения нужно передавать как параметры, а динамические фильтры строить со стабильной структурой. Query cache hit rate и SQL-логи помогают увидеть постоянную перекомпиляцию." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000032"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать global query filter для multi-tenancy?». Поэтому он не отвечает на текущую формулировку.", "Tenant filter должен использовать контекстное значение безопасного scoped-сервиса и применяться ко всем tenant-owned сущностям. Нельзя доверять tenant id из произвольного payload; его получают из проверенной identity. Административный IgnoreQueryFilters изолируют, тестируют обходы и учитывают, что pooled DbContext требует особой передачи tenant state." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000034"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда AsNoTrackingWithIdentityResolution полезнее AsNoTracking?». Поэтому он не отвечает на текущую формулировку.", "Если read-only результат содержит повторные ссылки на одну сущность, обычный no-tracking создаст несколько экземпляров. Identity resolution использует временный tracker только для материализации и возвращает единые ссылки без дальнейшего tracking. Это расходует дополнительные ресурсы, поэтому не нужно для плоской DTO-проекции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000041"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему AutoDetectChanges может стать bottleneck при массовой загрузке?». Поэтому он не отвечает на текущую формулировку.", "DetectChanges сравнивает tracked-граф с original values и при большом числе сущностей вызывается многократно некоторыми API. Для контролируемого bulk-сценария его временно отключают, добавляют данные пакетами и вызывают DetectChanges явно перед SaveChanges. Это требует аккуратности: иначе изменения или связи могут не сохраниться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000042"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему soft delete сложнее простого поля IsDeleted?». Поэтому он не отвечает на текущую формулировку.", "Нужны глобальные фильтры, правила уникальности только среди активных строк, каскадная семантика, аудит и политика физической очистки. IgnoreQueryFilters может случайно вернуть удалённые данные, а навигации — дать неожиданный результат. Для некоторых данных temporal/audit table или отдельный статус жизненного цикла честнее." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000043"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как каскадное удаление связано с границами агрегата?». Поэтому он не отвечает на текущую формулировку.", "Owned dependents внутри агрегата логично удалять вместе с root, и cascade отражает это правило. Между агрегатами database cascade может удалить данные без доменной проверки и создать длинные блокировки; чаще используют Restrict и отдельный use case. Поведение EF и самой БД нужно согласовать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000052"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем ExecuteUpdate/ExecuteDelete отличаются от изменения загруженных entities?». Поэтому он не отвечает на текущую формулировку.", "Они формируют set-based SQL и не загружают сущности в память, поэтому эффективны для массовых изменений. Операция обходит ChangeTracker, доменные методы и его текущее состояние; tracked-объекты могут стать устаревшими. Инварианты, concurrency и транзакционную границу нужно обеспечить явно." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000053"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда interceptor EF Core уместен, а когда он скрывает бизнес-логику?». Поэтому он не отвечает на текущую формулировку.", "Interceptor полезен для cross-cutting concerns: telemetry, command tagging, connection hooks или построение outbox на SaveChanges. Бизнес-решения и изменения агрегатов в нём становятся неявными и зависят от порядка вызовов. Interceptor должен быть детерминированным, быстрым и иметь тесты на retry и транзакции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000054"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как хранить outbox-сообщения вместе с агрегатом через EF Core?». Поэтому он не отвечает на текущую формулировку.", "Domain events преобразуют в outbox rows и добавляют в тот же DbContext до SaveChanges, чтобы данные и намерение публикации зафиксировались одной транзакцией. Отдельный worker публикует их с retry и помечает обработанными. Получатель остаётся идемпотентным, потому что crash между publish и отметкой создаёт дубликат." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000061"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как execution strategy с retry взаимодействует с пользовательской транзакцией?». Поэтому он не отвечает на текущую формулировку.", "Retry должен повторять весь логический блок как единицу, иначе состояние после частичного выполнения неопределённо. Пользовательскую транзакцию создают внутри ExecuteAsync выбранной strategy и делают операции идемпотентными либо проверяемыми. Нельзя просто обернуть SaveChanges retry, если рядом есть внешние side effects." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000063"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как безопасно использовать FromSql и динамические части SQL?». Поэтому он не отвечает на текущую формулировку.", "Значения всегда параметризуют через FromSqlInterpolated или параметры провайдера. Имена таблиц, колонок и направление сортировки параметризовать нельзя, поэтому их выбирают только из whitelist, а не из пользовательской строки. Нужно понимать composability запроса и не полагаться на escaping как на полноценную защиту." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000064"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему DbContext не следует прятать за generic repository во всех случаях?». Поэтому он не отвечает на текущую формулировку.", "DbContext уже реализует Unit of Work и repository-подобный доступ. Универсальный CRUD-интерфейс часто скрывает возможности LINQ, допускает операции вне агрегата и разрастается спецификациями. Репозиторий оправдан как доменный контракт для aggregate roots; read side может использовать специализированные queries." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000071"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие гарантии даёт SaveChanges и когда нужна явная транзакция?». Поэтому он не отвечает на текущую формулировку.", "Один вызов SaveChanges обычно выполняется атомарно в транзакции провайдера. Явная транзакция нужна, когда единый инвариант охватывает несколько SaveChanges, raw SQL или другие операции той же БД. Её держат короткой; внешние HTTP или broker-вызовы внутрь не помещают, применяя outbox." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000072"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему InMemory provider плохо имитирует реляционную базу в интеграционных тестах?». Поэтому он не отвечает на текущую формулировку.", "Он не проверяет SQL translation, ограничения, транзакции, collation, null semantics и поведение конкретного провайдера. Для unit-тестов домена база не нужна; для persistence-тестов используют реальный engine в контейнере или SQLite только если его различия допустимы. Критичные запросы тестируют на production-провайдере." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000074"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как моделировать JSON-колонку и когда нормализация лучше?». Поэтому он не отвечает на текущую формулировку.", "JSON удобен для атомарного вложенного документа с изменяемой схемой и редкими междокументными связями. Нужно проверить поддержку provider для query/update, индексы по путям и change tracking. Если поля участвуют в constraints, joins, частых частичных обновлениях или независимом жизненном цикле, нормализованная модель обычно прозрачнее." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000081"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Для чего EF Core создаёт savepoint внутри существующей транзакции?». Поэтому он не отвечает на текущую формулировку.", "Перед SaveChanges EF может создать savepoint, чтобы при ошибке откатить только этот вызов и оставить транзакцию в пригодном состоянии, например для разрешения concurrency conflict. Поддержка зависит от провайдера и настроек. Это не заменяет общую обработку ошибки и решение, можно ли безопасно продолжать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000082"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как подготовить zero-downtime миграцию для переименования обязательной колонки?». Поэтому он не отвечает на текущую формулировку.", "Применяют expand-contract: сначала добавляют совместимую nullable/default колонку, разворачивают код с dual read/write или backfill, затем переключают чтение и только в следующем релизе удаляют старую. Долгие index build и table rewrite планируют отдельно. Миграции не должны предполагать мгновенное обновление всех экземпляров." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000083"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как организовать чтение с replica, не нарушив read-your-writes?». Поэтому он не отвечает на текущую формулировку.", "Отдельный read DbContext направляют на replica только для tolerant-to-staleness сценариев. После команды пользователь может читать primary, передавать consistency token/временное окно или ждать позиции репликации. Routing нельзя скрывать полностью: use case должен знать требуемую консистентность." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000092"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как корректно разрешать DbUpdateConcurrencyException?». Поэтому он не отвечает на текущую формулировку.", "Сначала определяют бизнес-политику: client wins, store wins или merge отдельных полей. Затем получают database values, обновляют original values и повторяют ограниченное число раз только безопасную транзакцию. Слепой retry без повторной проверки инварианта может перезаписать чужое изменение." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000093"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему автоматический Database.Migrate на старте опасен в нескольких production-инстансах?». Поэтому он не отвечает на текущую формулировку.", "Несколько экземпляров могут одновременно менять схему, блокировать startup и получить разные результаты при частичной ошибке. Production-миграции лучше выполнять отдельным контролируемым job с правами DDL, backup и наблюдаемостью. Автомиграция удобна для локального MVP, но это осознанное ограничение окружения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000094"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как кэшировать результаты EF-запросов без выдачи устаревших критичных данных?». Поэтому он не отвечает на текущую формулировку.", "Кэшируют DTO/read model, задают ключ с tenant и параметрами, ограниченный TTL и размер. Для важных обновлений используют invalidation/event version, но принимают возможность гонки. Кэш не должен возвращать tracked entities и не заменяет корректный источник истины." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000101"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как маппить value object, сохраняя его доменную семантику?». Поэтому он не отвечает на текущую формулировку.", "Для набора полей используют owned или complex type, а для одного столбца — value converter. Изменяемому преобразованному типу часто нужен ValueComparer, иначе ChangeTracker не увидит изменение. Конструктор и приватные свойства позволяют сохранить валидацию, но EF materialization не должен создавать недопустимое состояние." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000103"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как связать LINQ-запрос с нужным индексом, не пытаясь дать EF hint?». Поэтому он не отвечает на текущую формулировку.", "Начинают с сгенерированного SQL и плана базы: порядок фильтров в LINQ сам по себе не задаёт порядок индекса. Проектируют индекс по equality/range predicates, sort и selectivity, при необходимости include/partial возможности провайдера. Затем измеряют чтения и latency на репрезентативных данных." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000104"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как диагностировать медленный запрос EF Core от HTTP до базы?». Поэтому он не отвечает на текущую формулировку.", "Коррелируют trace запроса с EF command activity, фиксируют SQL, параметры, число roundtrips и время ожидания соединения. В базе анализируют actual plan, rows, buffers, locks и статистику; отдельно измеряют materialization и serialization. Оптимизацию начинают с доминирующего участка, а не с LINQ-косметики." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000111"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие компромиссы у TPH, TPT и TPC наследования?». Поэтому он не отвечает на текущую формулировку.", "TPH хранит иерархию в одной таблице, обычно быстрее читает, но имеет nullable-столбцы и широкий ряд. TPT нормализует типы, однако сложные запросы требуют множества joins. TPC дублирует базовые столбцы и хорошо читает конкретные типы, но усложняет общие ключи и изменения схемы. Выбор подтверждают реальными запросами." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000112"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое cartesian explosion при нескольких Include коллекций одного уровня?». Поэтому он не отвечает на текущую формулировку.", "JOIN двух sibling-коллекций создаёт произведение их строк: 10 элементов одной и 10 другой дают 100 строк на корень, хотя объектов меньше. Это увеличивает сеть и materialization. Помогают проекция, split query, отдельные запросы или изменение read model." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000114"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда нужен отдельный read model вместо всё более сложного EF-запроса по write model?». Поэтому он не отвечает на текущую формулировку.", "Если экран постоянно требует тяжёлых joins, денормализации, истории или иной формы данных, сложность и нагрузка сигнализируют о специализированной проекции. Read model обновляют синхронно в той же БД либо асинхронно с явной eventual consistency. Это компромисс между скоростью чтения, свежестью и операционной сложностью." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000121"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как избежать случайной перезаписи полей при disconnected update из API?». Поэтому он не отвечает на текущую формулировку.", "Не следует принимать entity целиком и помечать её Modified. Загружают агрегат, применяют валидированную команду через доменные методы и сохраняют изменённые поля; для patch явно перечисляют разрешённые изменения. Concurrency token защищает от lost update, а DTO отделяет контракт от persistence-модели." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000122"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать размер batch при SaveChanges и массовых операциях?». Поэтому он не отвечает на текущую формулировку.", "Batch уменьшает roundtrips, но слишком большой пакет увеличивает SQL, параметры, locks, memory и время транзакции. Провайдер имеет собственные пределы и heuristics. Измеряют throughput и p95 на реальной сети; для очень больших загрузок используют bulk/native copy, staging table или set-based команды." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000123"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем отличаются tracking и no-tracking запросы в Entity Framework Core?». Поэтому он не отвечает на текущую формулировку.", "Tracking-запросы помещают сущности в ChangeTracker, поддерживают identity resolution и позволяют сохранить изменения через SaveChanges. AsNoTracking уменьшает расход памяти и CPU для read-only сценариев. Для сложных read-only графов возможен AsNoTrackingWithIdentityResolution, который устраняет дубликаты объектов без постоянного tracking." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000132"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать global query filter для multi-tenancy?». Поэтому он не отвечает на текущую формулировку.", "Tenant filter должен использовать контекстное значение безопасного scoped-сервиса и применяться ко всем tenant-owned сущностям. Нельзя доверять tenant id из произвольного payload; его получают из проверенной identity. Административный IgnoreQueryFilters изолируют, тестируют обходы и учитывают, что pooled DbContext требует особой передачи tenant state." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000133"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что происходит, когда часть LINQ-выражения не переводится в SQL?». Поэтому он не отвечает на текущую формулировку.", "Современный EF обычно выбрасывает исключение вне верхней client projection, чтобы не загрузить таблицу незаметно. Нужно переписать выражение в поддерживаемую форму, вынести вычисление после узкой материализации или добавить mapping database function. AsEnumerable ставят только после явного ограничения данных." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000134"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое проблема N+1 и как её обнаружить и устранить в EF Core?». Поэтому он не отвечает на текущую формулировку.", "N+1 возникает, когда после одного запроса списка выполняется отдельный запрос для каждой записи. Её видно по логам SQL, профилировщику и метрикам количества запросов. Обычно помогают проекция Select, осознанный Include, пакетная загрузка и отключение неуместной lazy loading." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000141"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему soft delete сложнее простого поля IsDeleted?». Поэтому он не отвечает на текущую формулировку.", "Нужны глобальные фильтры, правила уникальности только среди активных строк, каскадная семантика, аудит и политика физической очистки. IgnoreQueryFilters может случайно вернуть удалённые данные, а навигации — дать неожиданный результат. Для некоторых данных temporal/audit table или отдельный статус жизненного цикла честнее." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000143"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать read-only запрос с большим графом без materialization доменных entities?». Поэтому он не отвечает на текущую формулировку.", "Проецируют сразу в DTO только нужные поля, применяют фильтр и пагинацию до materialization, используют AsNoTracking и избегают Include, если Select уже выражает форму. Это уменьшает данные, ChangeTracker и coupling. Сгенерированный SQL и число roundtrips всё равно проверяют." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000144"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда использовать Include, а когда проекцию Select?». Поэтому он не отвечает на текущую формулировку.", "Include нужен, когда требуется материализовать и изменять граф доменных сущностей. Для чтения и API-ответов предпочтительнее Select в DTO: он выбирает только необходимые столбцы, уменьшает объём данных и часто формирует более простой SQL. Include не влияет на проекцию, если итоговый результат уже не является сущностью." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000151"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда interceptor EF Core уместен, а когда он скрывает бизнес-логику?». Поэтому он не отвечает на текущую формулировку.", "Interceptor полезен для cross-cutting concerns: telemetry, command tagging, connection hooks или построение outbox на SaveChanges. Бизнес-решения и изменения агрегатов в нём становятся неявными и зависят от порядка вызовов. Interceptor должен быть детерминированным, быстрым и иметь тесты на retry и транзакции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000152"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда AsNoTrackingWithIdentityResolution полезнее AsNoTracking?». Поэтому он не отвечает на текущую формулировку.", "Если read-only результат содержит повторные ссылки на одну сущность, обычный no-tracking создаст несколько экземпляров. Identity resolution использует временный tracker только для материализации и возвращает единые ссылки без дальнейшего tracking. Это расходует дополнительные ресурсы, поэтому не нужно для плоской DTO-проекции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000154"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как организовать optimistic concurrency в EF Core?». Поэтому он не отвечает на текущую формулировку.", "В модель добавляют concurrency token, часто rowversion или явно управляемую версию. EF включает исходное значение токена в условие UPDATE/DELETE и при конфликте выбрасывает DbUpdateConcurrencyException. Приложение должно выбрать стратегию: повтор, слияние изменений или сообщение пользователю." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000161"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как безопасно использовать FromSql и динамические части SQL?». Поэтому он не отвечает на текущую формулировку.", "Значения всегда параметризуют через FromSqlInterpolated или параметры провайдера. Имена таблиц, колонок и направление сортировки параметризовать нельзя, поэтому их выбирают только из whitelist, а не из пользовательской строки. Нужно понимать composability запроса и не полагаться на escaping как на полноценную защиту." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000162"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как каскадное удаление связано с границами агрегата?». Поэтому он не отвечает на текущую формулировку.", "Owned dependents внутри агрегата логично удалять вместе с root, и cascade отражает это правило. Между агрегатами database cascade может удалить данные без доменной проверки и создать длинные блокировки; чаще используют Restrict и отдельный use case. Поведение EF и самой БД нужно согласовать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000163"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему DbContext имеет scoped lifetime и какие риски возникают при его совместном использовании между потоками?». Поэтому он не отвечает на текущую формулировку.", "DbContext представляет unit of work и обычно живёт в рамках одной операции. Он не является thread-safe: параллельные запросы и изменения одного экземпляра приводят к исключениям и повреждению состояния tracking. В долгоживущих процессах и Blazor Server применяют короткие scope, transient context или IDbContextFactory." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000172"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему InMemory provider плохо имитирует реляционную базу в интеграционных тестах?». Поэтому он не отвечает на текущую формулировку.", "Он не проверяет SQL translation, ограничения, транзакции, collation, null semantics и поведение конкретного провайдера. Для unit-тестов домена база не нужна; для persistence-тестов используют реальный engine в контейнере или SQLite только если его различия допустимы. Критичные запросы тестируют на production-провайдере." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000173"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как хранить outbox-сообщения вместе с агрегатом через EF Core?». Поэтому он не отвечает на текущую формулировку.", "Domain events преобразуют в outbox rows и добавляют в тот же DbContext до SaveChanges, чтобы данные и намерение публикации зафиксировались одной транзакцией. Отдельный worker публикует их с retry и помечает обработанными. Получатель остаётся идемпотентным, потому что crash между publish и отметкой создаёт дубликат." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000174"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда split query лучше single query и какой новый риск он создаёт?». Поэтому он не отвечает на текущую формулировку.", "Single query может породить cartesian explosion при нескольких коллекциях Include и передать много дублированных данных. Split query выполняет несколько SQL-запросов и уменьшает дублирование, но добавляет roundtrips и без подходящей транзакции может увидеть несогласованные снимки. Выбор делают по форме графа, объёму данных и измеренному SQL." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000181"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как подготовить zero-downtime миграцию для переименования обязательной колонки?». Поэтому он не отвечает на текущую формулировку.", "Применяют expand-contract: сначала добавляют совместимую nullable/default колонку, разворачивают код с dual read/write или backfill, затем переключают чтение и только в следующем релизе удаляют старую. Долгие index build и table rewrite планируют отдельно. Миграции не должны предполагать мгновенное обновление всех экземпляров." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000183"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему DbContext не следует прятать за generic repository во всех случаях?». Поэтому он не отвечает на текущую формулировку.", "DbContext уже реализует Unit of Work и repository-подобный доступ. Универсальный CRUD-интерфейс часто скрывает возможности LINQ, допускает операции вне агрегата и разрастается спецификациями. Репозиторий оправдан как доменный контракт для aggregate roots; read side может использовать специализированные queries." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000184"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как реализовать keyset pagination в EF Core и почему она устойчивее Offset/Limit?». Поэтому он не отвечает на текущую формулировку.", "Вместо Skip страница фильтруется по последнему уникально упорядоченному ключу, например CreatedAt < cursorDate либо лексикографической паре CreatedAt/Id. База продолжает чтение с позиции индекса и не пересчитывает все предыдущие строки. Нужен стабильный уникальный порядок и составной индекс, совпадающий с фильтром и сортировкой." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000191"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему автоматический Database.Migrate на старте опасен в нескольких production-инстансах?». Поэтому он не отвечает на текущую формулировку.", "Несколько экземпляров могут одновременно менять схему, блокировать startup и получить разные результаты при частичной ошибке. Production-миграции лучше выполнять отдельным контролируемым job с правами DDL, backup и наблюдаемостью. Автомиграция удобна для локального MVP, но это осознанное ограничение окружения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000192"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как моделировать JSON-колонку и когда нормализация лучше?». Поэтому он не отвечает на текущую формулировку.", "JSON удобен для атомарного вложенного документа с изменяемой схемой и редкими междокументными связями. Нужно проверить поддержку provider для query/update, индексы по путям и change tracking. Если поля участвуют в constraints, joins, частых частичных обновлениях или независимом жизненном цикле, нормализованная модель обычно прозрачнее." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000194"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что даёт DbContext pooling и какие данные нельзя оставлять в pooled context?». Поэтому он не отвечает на текущую формулировку.", "Pooling переиспользует экземпляры DbContext и уменьшает стоимость инициализации, но OnConfiguring обычно выполняется один раз. В context нельзя хранить request-specific состояние, tenant id или изменяемые флаги без гарантированного сброса. Пул не делает DbContext потокобезопасным и не заменяет pooling соединений драйвера." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000201"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как связать LINQ-запрос с нужным индексом, не пытаясь дать EF hint?». Поэтому он не отвечает на текущую формулировку.", "Начинают с сгенерированного SQL и плана базы: порядок фильтров в LINQ сам по себе не задаёт порядок индекса. Проектируют индекс по equality/range predicates, sort и selectivity, при необходимости include/partial возможности провайдера. Затем измеряют чтения и latency на репрезентативных данных." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000202"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как организовать чтение с replica, не нарушив read-your-writes?». Поэтому он не отвечает на текущую формулировку.", "Отдельный read DbContext направляют на replica только для tolerant-to-staleness сценариев. После команды пользователь может читать primary, передавать consistency token/временное окно или ждать позиции репликации. Routing нельзя скрывать полностью: use case должен знать требуемую консистентность." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000203"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда compiled query имеет смысл и почему она не исправит медленный SQL?». Поэтому он не отвечает на текущую формулировку.", "Compiled query уменьшает overhead анализа expression tree и поиска в query cache в очень горячем повторяющемся запросе одной формы. Она не меняет план базы, индексы, число строк или network latency. Сначала оптимизируют SQL и roundtrips, затем benchmark показывает, значима ли доля самого EF." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000212"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое cartesian explosion при нескольких Include коллекций одного уровня?». Поэтому он не отвечает на текущую формулировку.", "JOIN двух sibling-коллекций создаёт произведение их строк: 10 элементов одной и 10 другой дают 100 строк на корень, хотя объектов меньше. Это увеличивает сеть и materialization. Помогают проекция, split query, отдельные запросы или изменение read model." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000213"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как кэшировать результаты EF-запросов без выдачи устаревших критичных данных?». Поэтому он не отвечает на текущую формулировку.", "Кэшируют DTO/read model, задают ключ с tenant и параметрами, ограниченный TTL и размер. Для важных обновлений используют invalidation/event version, но принимают возможность гонки. Кэш не должен возвращать tracked entities и не заменяет корректный источник истины." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000214"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как форма LINQ-выражения влияет на query cache и план-кэш базы?». Поэтому он не отвечает на текущую формулировку.", "Константы, динамически встроенные в expression tree, создают новые формы запросов и могут загрязнять кэши EF и БД. Значения нужно передавать как параметры, а динамические фильтры строить со стабильной структурой. Query cache hit rate и SQL-логи помогают увидеть постоянную перекомпиляцию." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000221"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать размер batch при SaveChanges и массовых операциях?». Поэтому он не отвечает на текущую формулировку.", "Batch уменьшает roundtrips, но слишком большой пакет увеличивает SQL, параметры, locks, memory и время транзакции. Провайдер имеет собственные пределы и heuristics. Измеряют throughput и p95 на реальной сети; для очень больших загрузок используют bulk/native copy, staging table или set-based команды." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000223"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как диагностировать медленный запрос EF Core от HTTP до базы?». Поэтому он не отвечает на текущую формулировку.", "Коррелируют trace запроса с EF command activity, фиксируют SQL, параметры, число roundtrips и время ожидания соединения. В базе анализируют actual plan, rows, buffers, locks и статистику; отдельно измеряют materialization и serialization. Оптимизацию начинают с доминирующего участка, а не с LINQ-косметики." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000224"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему AutoDetectChanges может стать bottleneck при массовой загрузке?». Поэтому он не отвечает на текущую формулировку.", "DetectChanges сравнивает tracked-граф с original values и при большом числе сущностей вызывается многократно некоторыми API. Для контролируемого bulk-сценария его временно отключают, добавляют данные пакетами и вызывают DetectChanges явно перед SaveChanges. Это требует аккуратности: иначе изменения или связи могут не сохраниться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000231"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что происходит, когда часть LINQ-выражения не переводится в SQL?». Поэтому он не отвечает на текущую формулировку.", "Современный EF обычно выбрасывает исключение вне верхней client projection, чтобы не загрузить таблицу незаметно. Нужно переписать выражение в поддерживаемую форму, вынести вычисление после узкой материализации или добавить mapping database function. AsEnumerable ставят только после явного ограничения данных." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000232"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда нужен отдельный read model вместо всё более сложного EF-запроса по write model?». Поэтому он не отвечает на текущую формулировку.", "Если экран постоянно требует тяжёлых joins, денормализации, истории или иной формы данных, сложность и нагрузка сигнализируют о специализированной проекции. Read model обновляют синхронно в той же БД либо асинхронно с явной eventual consistency. Это компромисс между скоростью чтения, свежестью и операционной сложностью." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000234"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем ExecuteUpdate/ExecuteDelete отличаются от изменения загруженных entities?». Поэтому он не отвечает на текущую формулировку.", "Они формируют set-based SQL и не загружают сущности в память, поэтому эффективны для массовых изменений. Операция обходит ChangeTracker, доменные методы и его текущее состояние; tracked-объекты могут стать устаревшими. Инварианты, concurrency и транзакционную границу нужно обеспечить явно." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000241"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать read-only запрос с большим графом без materialization доменных entities?». Поэтому он не отвечает на текущую формулировку.", "Проецируют сразу в DTO только нужные поля, применяют фильтр и пагинацию до materialization, используют AsNoTracking и избегают Include, если Select уже выражает форму. Это уменьшает данные, ChangeTracker и coupling. Сгенерированный SQL и число roundtrips всё равно проверяют." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000242"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем отличаются tracking и no-tracking запросы в Entity Framework Core?». Поэтому он не отвечает на текущую формулировку.", "Tracking-запросы помещают сущности в ChangeTracker, поддерживают identity resolution и позволяют сохранить изменения через SaveChanges. AsNoTracking уменьшает расход памяти и CPU для read-only сценариев. Для сложных read-only графов возможен AsNoTrackingWithIdentityResolution, который устраняет дубликаты объектов без постоянного tracking." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000243"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как execution strategy с retry взаимодействует с пользовательской транзакцией?». Поэтому он не отвечает на текущую формулировку.", "Retry должен повторять весь логический блок как единицу, иначе состояние после частичного выполнения неопределённо. Пользовательскую транзакцию создают внутри ExecuteAsync выбранной strategy и делают операции идемпотентными либо проверяемыми. Нельзя просто обернуть SaveChanges retry, если рядом есть внешние side effects." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000252"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда AsNoTrackingWithIdentityResolution полезнее AsNoTracking?». Поэтому он не отвечает на текущую формулировку.", "Если read-only результат содержит повторные ссылки на одну сущность, обычный no-tracking создаст несколько экземпляров. Identity resolution использует временный tracker только для материализации и возвращает единые ссылки без дальнейшего tracking. Это расходует дополнительные ресурсы, поэтому не нужно для плоской DTO-проекции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000253"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое проблема N+1 и как её обнаружить и устранить в EF Core?». Поэтому он не отвечает на текущую формулировку.", "N+1 возникает, когда после одного запроса списка выполняется отдельный запрос для каждой записи. Её видно по логам SQL, профилировщику и метрикам количества запросов. Обычно помогают проекция Select, осознанный Include, пакетная загрузка и отключение неуместной lazy loading." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000254"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие гарантии даёт SaveChanges и когда нужна явная транзакция?». Поэтому он не отвечает на текущую формулировку.", "Один вызов SaveChanges обычно выполняется атомарно в транзакции провайдера. Явная транзакция нужна, когда единый инвариант охватывает несколько SaveChanges, raw SQL или другие операции той же БД. Её держат короткой; внешние HTTP или broker-вызовы внутрь не помещают, применяя outbox." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000261"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как каскадное удаление связано с границами агрегата?». Поэтому он не отвечает на текущую формулировку.", "Owned dependents внутри агрегата логично удалять вместе с root, и cascade отражает это правило. Между агрегатами database cascade может удалить данные без доменной проверки и создать длинные блокировки; чаще используют Restrict и отдельный use case. Поведение EF и самой БД нужно согласовать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000263"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда использовать Include, а когда проекцию Select?». Поэтому он не отвечает на текущую формулировку.", "Include нужен, когда требуется материализовать и изменять граф доменных сущностей. Для чтения и API-ответов предпочтительнее Select в DTO: он выбирает только необходимые столбцы, уменьшает объём данных и часто формирует более простой SQL. Include не влияет на проекцию, если итоговый результат уже не является сущностью." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000264"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Для чего EF Core создаёт savepoint внутри существующей транзакции?». Поэтому он не отвечает на текущую формулировку.", "Перед SaveChanges EF может создать savepoint, чтобы при ошибке откатить только этот вызов и оставить транзакцию в пригодном состоянии, например для разрешения concurrency conflict. Поддержка зависит от провайдера и настроек. Это не заменяет общую обработку ошибки и решение, можно ли безопасно продолжать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000271"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как хранить outbox-сообщения вместе с агрегатом через EF Core?». Поэтому он не отвечает на текущую формулировку.", "Domain events преобразуют в outbox rows и добавляют в тот же DbContext до SaveChanges, чтобы данные и намерение публикации зафиксировались одной транзакцией. Отдельный worker публикует их с retry и помечает обработанными. Получатель остаётся идемпотентным, потому что crash между publish и отметкой создаёт дубликат." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000272"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как организовать optimistic concurrency в EF Core?». Поэтому он не отвечает на текущую формулировку.", "В модель добавляют concurrency token, часто rowversion или явно управляемую версию. EF включает исходное значение токена в условие UPDATE/DELETE и при конфликте выбрасывает DbUpdateConcurrencyException. Приложение должно выбрать стратегию: повтор, слияние изменений или сообщение пользователю." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000274"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как корректно разрешать DbUpdateConcurrencyException?». Поэтому он не отвечает на текущую формулировку.", "Сначала определяют бизнес-политику: client wins, store wins или merge отдельных полей. Затем получают database values, обновляют original values и повторяют ограниченное число раз только безопасную транзакцию. Слепой retry без повторной проверки инварианта может перезаписать чужое изменение." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000281"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему DbContext не следует прятать за generic repository во всех случаях?». Поэтому он не отвечает на текущую формулировку.", "DbContext уже реализует Unit of Work и repository-подобный доступ. Универсальный CRUD-интерфейс часто скрывает возможности LINQ, допускает операции вне агрегата и разрастается спецификациями. Репозиторий оправдан как доменный контракт для aggregate roots; read side может использовать специализированные queries." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000282"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему DbContext имеет scoped lifetime и какие риски возникают при его совместном использовании между потоками?». Поэтому он не отвечает на текущую формулировку.", "DbContext представляет unit of work и обычно живёт в рамках одной операции. Он не является thread-safe: параллельные запросы и изменения одного экземпляра приводят к исключениям и повреждению состояния tracking. В долгоживущих процессах и Blazor Server применяют короткие scope, transient context или IDbContextFactory." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000283"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как маппить value object, сохраняя его доменную семантику?». Поэтому он не отвечает на текущую формулировку.", "Для набора полей используют owned или complex type, а для одного столбца — value converter. Изменяемому преобразованному типу часто нужен ValueComparer, иначе ChangeTracker не увидит изменение. Конструктор и приватные свойства позволяют сохранить валидацию, но EF materialization не должен создавать недопустимое состояние." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000292"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как моделировать JSON-колонку и когда нормализация лучше?». Поэтому он не отвечает на текущую формулировку.", "JSON удобен для атомарного вложенного документа с изменяемой схемой и редкими междокументными связями. Нужно проверить поддержку provider для query/update, индексы по путям и change tracking. Если поля участвуют в constraints, joins, частых частичных обновлениях или независимом жизненном цикле, нормализованная модель обычно прозрачнее." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000293"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда split query лучше single query и какой новый риск он создаёт?». Поэтому он не отвечает на текущую формулировку.", "Single query может породить cartesian explosion при нескольких коллекциях Include и передать много дублированных данных. Split query выполняет несколько SQL-запросов и уменьшает дублирование, но добавляет roundtrips и без подходящей транзакции может увидеть несогласованные снимки. Выбор делают по форме графа, объёму данных и измеренному SQL." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000294"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие компромиссы у TPH, TPT и TPC наследования?». Поэтому он не отвечает на текущую формулировку.", "TPH хранит иерархию в одной таблице, обычно быстрее читает, но имеет nullable-столбцы и широкий ряд. TPT нормализует типы, однако сложные запросы требуют множества joins. TPC дублирует базовые столбцы и хорошо читает конкретные типы, но усложняет общие ключи и изменения схемы. Выбор подтверждают реальными запросами." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000301"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как организовать чтение с replica, не нарушив read-your-writes?». Поэтому он не отвечает на текущую формулировку.", "Отдельный read DbContext направляют на replica только для tolerant-to-staleness сценариев. После команды пользователь может читать primary, передавать consistency token/временное окно или ждать позиции репликации. Routing нельзя скрывать полностью: use case должен знать требуемую консистентность." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000303"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как реализовать keyset pagination в EF Core и почему она устойчивее Offset/Limit?». Поэтому он не отвечает на текущую формулировку.", "Вместо Skip страница фильтруется по последнему уникально упорядоченному ключу, например CreatedAt < cursorDate либо лексикографической паре CreatedAt/Id. База продолжает чтение с позиции индекса и не пересчитывает все предыдущие строки. Нужен стабильный уникальный порядок и составной индекс, совпадающий с фильтром и сортировкой." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000304"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как избежать случайной перезаписи полей при disconnected update из API?». Поэтому он не отвечает на текущую формулировку.", "Не следует принимать entity целиком и помечать её Modified. Загружают агрегат, применяют валидированную команду через доменные методы и сохраняют изменённые поля; для patch явно перечисляют разрешённые изменения. Concurrency token защищает от lost update, а DTO отделяет контракт от persistence-модели." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000311"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как кэшировать результаты EF-запросов без выдачи устаревших критичных данных?». Поэтому он не отвечает на текущую формулировку.", "Кэшируют DTO/read model, задают ключ с tenant и параметрами, ограниченный TTL и размер. Для важных обновлений используют invalidation/event version, но принимают возможность гонки. Кэш не должен возвращать tracked entities и не заменяет корректный источник истины." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000312"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что даёт DbContext pooling и какие данные нельзя оставлять в pooled context?». Поэтому он не отвечает на текущую формулировку.", "Pooling переиспользует экземпляры DbContext и уменьшает стоимость инициализации, но OnConfiguring обычно выполняется один раз. В context нельзя хранить request-specific состояние, tenant id или изменяемые флаги без гарантированного сброса. Пул не делает DbContext потокобезопасным и не заменяет pooling соединений драйвера." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000314"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать global query filter для multi-tenancy?». Поэтому он не отвечает на текущую формулировку.", "Tenant filter должен использовать контекстное значение безопасного scoped-сервиса и применяться ко всем tenant-owned сущностям. Нельзя доверять tenant id из произвольного payload; его получают из проверенной identity. Административный IgnoreQueryFilters изолируют, тестируют обходы и учитывают, что pooled DbContext требует особой передачи tenant state." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000321"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как диагностировать медленный запрос EF Core от HTTP до базы?». Поэтому он не отвечает на текущую формулировку.", "Коррелируют trace запроса с EF command activity, фиксируют SQL, параметры, число roundtrips и время ожидания соединения. В базе анализируют actual plan, rows, buffers, locks и статистику; отдельно измеряют materialization и serialization. Оптимизацию начинают с доминирующего участка, а не с LINQ-косметики." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000322"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда compiled query имеет смысл и почему она не исправит медленный SQL?». Поэтому он не отвечает на текущую формулировку.", "Compiled query уменьшает overhead анализа expression tree и поиска в query cache в очень горячем повторяющемся запросе одной формы. Она не меняет план базы, индексы, число строк или network latency. Сначала оптимизируют SQL и roundtrips, затем benchmark показывает, значима ли доля самого EF." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000323"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему soft delete сложнее простого поля IsDeleted?». Поэтому он не отвечает на текущую формулировку.", "Нужны глобальные фильтры, правила уникальности только среди активных строк, каскадная семантика, аудит и политика физической очистки. IgnoreQueryFilters может случайно вернуть удалённые данные, а навигации — дать неожиданный результат. Для некоторых данных temporal/audit table или отдельный статус жизненного цикла честнее." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000332"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда нужен отдельный read model вместо всё более сложного EF-запроса по write model?». Поэтому он не отвечает на текущую формулировку.", "Если экран постоянно требует тяжёлых joins, денормализации, истории или иной формы данных, сложность и нагрузка сигнализируют о специализированной проекции. Read model обновляют синхронно в той же БД либо асинхронно с явной eventual consistency. Это компромисс между скоростью чтения, свежестью и операционной сложностью." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000333"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как форма LINQ-выражения влияет на query cache и план-кэш базы?». Поэтому он не отвечает на текущую формулировку.", "Константы, динамически встроенные в expression tree, создают новые формы запросов и могут загрязнять кэши EF и БД. Значения нужно передавать как параметры, а динамические фильтры строить со стабильной структурой. Query cache hit rate и SQL-логи помогают увидеть постоянную перекомпиляцию." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000334"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда interceptor EF Core уместен, а когда он скрывает бизнес-логику?». Поэтому он не отвечает на текущую формулировку.", "Interceptor полезен для cross-cutting concerns: telemetry, command tagging, connection hooks или построение outbox на SaveChanges. Бизнес-решения и изменения агрегатов в нём становятся неявными и зависят от порядка вызовов. Interceptor должен быть детерминированным, быстрым и иметь тесты на retry и транзакции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000341"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем отличаются tracking и no-tracking запросы в Entity Framework Core?». Поэтому он не отвечает на текущую формулировку.", "Tracking-запросы помещают сущности в ChangeTracker, поддерживают identity resolution и позволяют сохранить изменения через SaveChanges. AsNoTracking уменьшает расход памяти и CPU для read-only сценариев. Для сложных read-only графов возможен AsNoTrackingWithIdentityResolution, который устраняет дубликаты объектов без постоянного tracking." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000343"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему AutoDetectChanges может стать bottleneck при массовой загрузке?». Поэтому он не отвечает на текущую формулировку.", "DetectChanges сравнивает tracked-граф с original values и при большом числе сущностей вызывается многократно некоторыми API. Для контролируемого bulk-сценария его временно отключают, добавляют данные пакетами и вызывают DetectChanges явно перед SaveChanges. Это требует аккуратности: иначе изменения или связи могут не сохраниться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000344"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как безопасно использовать FromSql и динамические части SQL?». Поэтому он не отвечает на текущую формулировку.", "Значения всегда параметризуют через FromSqlInterpolated или параметры провайдера. Имена таблиц, колонок и направление сортировки параметризовать нельзя, поэтому их выбирают только из whitelist, а не из пользовательской строки. Нужно понимать composability запроса и не полагаться на escaping как на полноценную защиту." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000351"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое проблема N+1 и как её обнаружить и устранить в EF Core?». Поэтому он не отвечает на текущую формулировку.", "N+1 возникает, когда после одного запроса списка выполняется отдельный запрос для каждой записи. Её видно по логам SQL, профилировщику и метрикам количества запросов. Обычно помогают проекция Select, осознанный Include, пакетная загрузка и отключение неуместной lazy loading." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000352"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем ExecuteUpdate/ExecuteDelete отличаются от изменения загруженных entities?». Поэтому он не отвечает на текущую формулировку.", "Они формируют set-based SQL и не загружают сущности в память, поэтому эффективны для массовых изменений. Операция обходит ChangeTracker, доменные методы и его текущее состояние; tracked-объекты могут стать устаревшими. Инварианты, concurrency и транзакционную границу нужно обеспечить явно." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000354"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему InMemory provider плохо имитирует реляционную базу в интеграционных тестах?». Поэтому он не отвечает на текущую формулировку.", "Он не проверяет SQL translation, ограничения, транзакции, collation, null semantics и поведение конкретного провайдера. Для unit-тестов домена база не нужна; для persistence-тестов используют реальный engine в контейнере или SQLite только если его различия допустимы. Критичные запросы тестируют на production-провайдере." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000361"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда использовать Include, а когда проекцию Select?». Поэтому он не отвечает на текущую формулировку.", "Include нужен, когда требуется материализовать и изменять граф доменных сущностей. Для чтения и API-ответов предпочтительнее Select в DTO: он выбирает только необходимые столбцы, уменьшает объём данных и часто формирует более простой SQL. Include не влияет на проекцию, если итоговый результат уже не является сущностью." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000362"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как execution strategy с retry взаимодействует с пользовательской транзакцией?». Поэтому он не отвечает на текущую формулировку.", "Retry должен повторять весь логический блок как единицу, иначе состояние после частичного выполнения неопределённо. Пользовательскую транзакцию создают внутри ExecuteAsync выбранной strategy и делают операции идемпотентными либо проверяемыми. Нельзя просто обернуть SaveChanges retry, если рядом есть внешние side effects." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000363"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как подготовить zero-downtime миграцию для переименования обязательной колонки?». Поэтому он не отвечает на текущую формулировку.", "Применяют expand-contract: сначала добавляют совместимую nullable/default колонку, разворачивают код с dual read/write или backfill, затем переключают чтение и только в следующем релизе удаляют старую. Долгие index build и table rewrite планируют отдельно. Миграции не должны предполагать мгновенное обновление всех экземпляров." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000372"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как организовать optimistic concurrency в EF Core?». Поэтому он не отвечает на текущую формулировку.", "В модель добавляют concurrency token, часто rowversion или явно управляемую версию. EF включает исходное значение токена в условие UPDATE/DELETE и при конфликте выбрасывает DbUpdateConcurrencyException. Приложение должно выбрать стратегию: повтор, слияние изменений или сообщение пользователю." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000373"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие гарантии даёт SaveChanges и когда нужна явная транзакция?». Поэтому он не отвечает на текущую формулировку.", "Один вызов SaveChanges обычно выполняется атомарно в транзакции провайдера. Явная транзакция нужна, когда единый инвариант охватывает несколько SaveChanges, raw SQL или другие операции той же БД. Её держат короткой; внешние HTTP или broker-вызовы внутрь не помещают, применяя outbox." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000374"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему автоматический Database.Migrate на старте опасен в нескольких production-инстансах?». Поэтому он не отвечает на текущую формулировку.", "Несколько экземпляров могут одновременно менять схему, блокировать startup и получить разные результаты при частичной ошибке. Production-миграции лучше выполнять отдельным контролируемым job с правами DDL, backup и наблюдаемостью. Автомиграция удобна для локального MVP, но это осознанное ограничение окружения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000381"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему DbContext имеет scoped lifetime и какие риски возникают при его совместном использовании между потоками?». Поэтому он не отвечает на текущую формулировку.", "DbContext представляет unit of work и обычно живёт в рамках одной операции. Он не является thread-safe: параллельные запросы и изменения одного экземпляра приводят к исключениям и повреждению состояния tracking. В долгоживущих процессах и Blazor Server применяют короткие scope, transient context или IDbContextFactory." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000383"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Для чего EF Core создаёт savepoint внутри существующей транзакции?». Поэтому он не отвечает на текущую формулировку.", "Перед SaveChanges EF может создать savepoint, чтобы при ошибке откатить только этот вызов и оставить транзакцию в пригодном состоянии, например для разрешения concurrency conflict. Поддержка зависит от провайдера и настроек. Это не заменяет общую обработку ошибки и решение, можно ли безопасно продолжать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000384"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как связать LINQ-запрос с нужным индексом, не пытаясь дать EF hint?». Поэтому он не отвечает на текущую формулировку.", "Начинают с сгенерированного SQL и плана базы: порядок фильтров в LINQ сам по себе не задаёт порядок индекса. Проектируют индекс по equality/range predicates, sort и selectivity, при необходимости include/partial возможности провайдера. Затем измеряют чтения и latency на репрезентативных данных." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000391"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда split query лучше single query и какой новый риск он создаёт?». Поэтому он не отвечает на текущую формулировку.", "Single query может породить cartesian explosion при нескольких коллекциях Include и передать много дублированных данных. Split query выполняет несколько SQL-запросов и уменьшает дублирование, но добавляет roundtrips и без подходящей транзакции может увидеть несогласованные снимки. Выбор делают по форме графа, объёму данных и измеренному SQL." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000392"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как корректно разрешать DbUpdateConcurrencyException?». Поэтому он не отвечает на текущую формулировку.", "Сначала определяют бизнес-политику: client wins, store wins или merge отдельных полей. Затем получают database values, обновляют original values и повторяют ограниченное число раз только безопасную транзакцию. Слепой retry без повторной проверки инварианта может перезаписать чужое изменение." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000394"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое cartesian explosion при нескольких Include коллекций одного уровня?». Поэтому он не отвечает на текущую формулировку.", "JOIN двух sibling-коллекций создаёт произведение их строк: 10 элементов одной и 10 другой дают 100 строк на корень, хотя объектов меньше. Это увеличивает сеть и materialization. Помогают проекция, split query, отдельные запросы или изменение read model." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000401"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как реализовать keyset pagination в EF Core и почему она устойчивее Offset/Limit?». Поэтому он не отвечает на текущую формулировку.", "Вместо Skip страница фильтруется по последнему уникально упорядоченному ключу, например CreatedAt < cursorDate либо лексикографической паре CreatedAt/Id. База продолжает чтение с позиции индекса и не пересчитывает все предыдущие строки. Нужен стабильный уникальный порядок и составной индекс, совпадающий с фильтром и сортировкой." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000402"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как маппить value object, сохраняя его доменную семантику?». Поэтому он не отвечает на текущую формулировку.", "Для набора полей используют owned или complex type, а для одного столбца — value converter. Изменяемому преобразованному типу часто нужен ValueComparer, иначе ChangeTracker не увидит изменение. Конструктор и приватные свойства позволяют сохранить валидацию, но EF materialization не должен создавать недопустимое состояние." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("31000000-0000-0000-0000-000000000403"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать размер batch при SaveChanges и массовых операциях?». Поэтому он не отвечает на текущую формулировку.", "Batch уменьшает roundtrips, но слишком большой пакет увеличивает SQL, параметры, locks, memory и время транзакции. Провайдер имеет собственные пределы и heuristics. Измеряют throughput и p95 на реальной сети; для очень больших загрузок используют bulk/native copy, staging table или set-based команды." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000012"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда quorum queue предпочтительнее classic queue?». Поэтому он не отвечает на текущую формулировку.", "Quorum queue нужна для репликации, предсказуемого leader election и высокой сохранности данных; она подтверждает publish после кворума. Цена — дополнительная latency, disk и network overhead, отсутствие transient/exclusive сценариев и ограничения для огромных backlog. Временные очереди, минимальная latency или очень длинные логи могут требовать classic queue или stream." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000013"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему нельзя совместно использовать один channel между конкурентными publisher без синхронизации?». Поэтому он не отвечает на текущую формулировку.", "AMQP channel — логическая сессия с порядком frames и delivery tags; многие client operations не рассчитаны на конкурентную запись. Перемешивание publish frames или confirm state приводит к protocol errors и неверной корреляции. Используют channel per worker, ограниченный pool или сериализованный publisher согласно гарантиям клиента." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000014"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как настроить graceful shutdown consumer?». Поэтому он не отвечает на текущую формулировку.", "Сначала прекращают принимать новые deliveries или отменяют consumer, затем ждут завершения in-flight в пределах timeout и отправляют ack/nack. Channel закрывают после handlers, connection — последним. Если timeout истёк, незавершённые unacked доставки вернутся в очередь, поэтому обработка обязана быть идемпотентной." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000021"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что происходит с publish во время недоступности большинства реплик quorum queue?». Поэтому он не отвечает на текущую формулировку.", "Без кворума очередь не может безопасно подтвердить новые записи и сохранить consistency, поэтому publish не получает успешный confirm либо блокируется/завершается ошибкой согласно клиенту и timeout. Система выбирает сохранность данных вместо availability. Producer должен ограниченно повторить неопределённые сообщения после восстановления и не считать timeout доказательством отсутствия записи." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000023"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как коррелировать publisher confirms с исходными сообщениями при batch publish?». Поэтому он не отвечает на текущую формулировку.", "Publisher отслеживает monotonically increasing publish sequence number и хранит диапазоны outstanding сообщений. Ack/nack может иметь multiple=true и закрывать все sequence до указанного. Структура должна эффективно удалять диапазон, а при connection loss все оставшиеся считаются неопределёнными и могут быть повторены." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000024"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как ограничить размер сообщения и почему большие payload вредны для broker?». Поэтому он не отвечает на текущую формулировку.", "Большие сообщения увеличивают memory, disk I/O, replication traffic, latency и время redelivery. В broker и client задают разумный limit; крупный blob кладут в object storage, а в сообщение — ссылку, checksum и metadata с контролем lifetime и доступа. Компрессия помогает сети, но добавляет CPU и риск decompression bomb." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000031"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как спроектировать идемпотентный consumer с базой данных?». Поэтому он не отвечает на текущую формулировку.", "Сообщение получает устойчивый MessageId или business operation id. В одной локальной транзакции consumer фиксирует id в inbox/processed table с unique constraint и применяет изменение; дубликат превращается в no-op. Ack отправляют после commit, а срок хранения ключей выбирают по максимальному окну повторной доставки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000032"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда streams RabbitMQ лучше очередей?». Поэтому он не отвечает на текущую формулировку.", "Stream хранит append-only log, поддерживает replay по offset, несколько независимых читателей и очень большой backlog. Это подходит event log, fan-out и аналитической обработке. Очередь лучше для распределения задач, удаления после ack и сложной routing-семантики; operational модель и client API различаются." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000034"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать granularity сообщения для пакетной обработки?». Поэтому он не отвечает на текущую формулировку.", "Одно событие должно выражать атомарный бизнес-факт, но transport batch может объединять публикацию или обработку ради throughput. Огромный business batch усложняет retry: одна плохая запись повторяет всё. Если пакет неизбежен, нужна стратегия частичного результата, idempotency каждого элемента и ограничения размера." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000041"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему exactly-once delivery обычно является ложной целью в RabbitMQ-интеграции?». Поэтому он не отвечает на текущую формулировку.", "Broker не может атомарно согласовать ack с произвольным side effect в другой системе. Crash после commit, но до ack, приводит к redelivery; confirm может потеряться после принятого publish. Практическая модель — at-least-once transport плюс идемпотентная обработка, deduplication и бизнес-операции с устойчивым ключом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000042"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как partitioning через super streams влияет на порядок сообщений?». Поэтому он не отвечает на текущую формулировку.", "Глобальный порядок теряется, но сохраняется внутри partition. Routing key должен стабильно отправлять связанные события, например одного aggregate id, в одну partition. Число partition определяет параллелизм и стоимость, а consumer group распределяет их между экземплярами; hotspot key всё ещё ограничивает throughput." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000043"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как защититься от duplicate consumer execution одновременно на двух узлах?». Поэтому он не отвечает на текущую формулировку.", "Unique inbox key в БД остаётся источником истины, потому что broker redelivery и network partition допускают конкуренцию. Операцию выполняют в транзакции после успешной вставки ключа либо используют version/unique business constraint. Распределённый lock редко заменяет идемпотентность и добавляет собственные failure modes." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000052"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать prefetch для CPU-bound и I/O-bound consumer?». Поэтому он не отвечает на текущую формулировку.", "Prefetch ограничивает число unacked сообщений на consumer. Для CPU-bound обычно начинают около числа параллельных workers, для I/O-bound допускают больше, учитывая latency и connection limits. Большое значение повышает throughput, но увеличивает memory, время redelivery и несправедливость; настраивают по processing time, backlog и p95." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000053"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать schema evolution сообщений?». Поэтому он не отвечает на текущую формулировку.", "Контракт должен быть backward/forward совместим: добавляют optional поля с defaults, не меняют смысл существующих и версионируют breaking event type. Consumer применяет tolerant reader и тестируется на старых payload. Envelope содержит event type, schema version, id, causation/correlation и occurred time, но не должен скрывать бизнес-семантику." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000054"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда Single Active Consumer полезен?». Поэтому он не отвечает на текущую формулировку.", "Он даёт активного consumer с автоматическим failover и удобен, когда очередь должна обрабатываться последовательно. Цена — ограниченный throughput и пауза при переключении; порядок всё равно зависит от requeue и publisher routing. Для масштабирования по ключу лучше несколько partition с SAC на каждой." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000061"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как retry через nack/requeue может создать hot loop?». Поэтому он не отвечает на текущую формулировку.", "Сообщение немедленно возвращается в ту же очередь и снова попадает тому же или другому consumer, потребляя CPU и network без паузы. Лучше ограничивать попытки, направлять в delay/retry queue с TTL или delayed mechanism и после лимита — в DLQ. Причину и attempt count сохраняют в headers/metadata." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000063"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему domain event и integration event не обязаны быть одним типом?». Поэтому он не отвечает на текущую формулировку.", "Domain event отражает внутреннюю модель и может меняться вместе с ней. Integration event — стабильный внешний контракт, минимально раскрывающий данные и часто строящийся после commit. Разделение уменьшает coupling, позволяет обогащать и версионировать сообщение, не публикуя внутренние классы агрегата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000064"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как приоритетные очереди влияют на fairness и производительность?». Поэтому он не отвечает на текущую формулировку.", "Приоритет позволяет срочным сообщениям обгонять обычные, но слишком много уровней увеличивает внутренние структуры и CPU. Постоянный поток высокого приоритета может вызвать starvation низкого. Часто прозрачнее иметь несколько очередей с отдельными capacity/SLO и управляемым распределением consumers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000071"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какова безопасная модель обработки poison message?». Поэтому он не отвечает на текущую формулировку.", "Consumer различает транзиентную и постоянную ошибку, ограничивает число повторов и переносит неисправимое сообщение в DLQ вместе с причиной и correlation metadata. Нужны alert, инструмент просмотра и контролируемый replay после исправления. Бесконечный requeue скрывает проблему и блокирует полезную нагрузку." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000072"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как transactional outbox сочетается с publisher confirms?». Поэтому он не отвечает на текущую формулировку.", "Outbox атомарно сохраняет бизнес-изменение и сообщение в одной БД. Dispatcher публикует его и только после confirm отмечает отправленным; crash между этими действиями создаёт повторный publish. Поэтому outbox предотвращает потерю намерения, confirms подтверждают broker, а idempotent consumer закрывает дубликаты." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000074"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему большое количество очередей и bindings является архитектурным решением, а не бесплатной абстракцией?». Поэтому он не отвечает на текущую формулировку.", "Каждая очередь хранит состояние, метаданные, процессы и метрики; quorum queue добавляет replicas и consensus overhead. Огромная topology увеличивает recovery time и операционную сложность. Разделение делают по независимому backlog, SLA, retention или ownership, а не по каждому типу сообщения автоматически." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000081"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие риски у TTL + dead-letter exchange как механизма задержки?». Поэтому он не отвечает на текущую формулировку.", "В classic queue сообщение за большим TTL в голове может задержать истёкшие сообщения позади него, а dead-lettering по умолчанию может иметь weaker guarantees. Создают отдельные retry buckets с фиксированными TTL, контролируют размер и используют quorum at-least-once dead lettering, если нужна сохранность. Для сложного расписания лучше внешний scheduler." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000082"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как масштабировать consumers, сохраняя последовательность событий одного агрегата?». Поэтому он не отвечает на текущую формулировку.", "События маршрутизируют по aggregate id в фиксированную partition/queue и обрабатывают её последовательно одним активным consumer, а разные ключи — параллельно. Альтернатива — version check и буферизация out-of-order, что сложнее. Один глобальный consumer сохраняет порядок, но уничтожает масштабирование." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000083"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как отличить команду от события в messaging-контракте?». Поэтому он не отвечает на текущую формулировку.", "Команда выражает намерение конкретному владельцу и может быть отклонена; событие сообщает свершившийся факт и не адресует единственного исполнителя. Название, routing, retry и ожидания ответа различаются. Маскировка команды под событие создаёт скрытую оркестрацию и неясную ответственность." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000092"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как гарантировать, что unroutable message не исчезнет незаметно?». Поэтому он не отвечает на текущую формулировку.", "Publisher ставит mandatory и обрабатывает basic.return, одновременно используя confirms. Alternate exchange может собирать нерутируемые сообщения, но это другая бизнес-политика и требует мониторинга. Confirm означает принятие broker, а не обязательно попадание в ожидаемую очередь, поэтому оба сигнала различают." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000093"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие метрики RabbitMQ важнее простого queue depth?». Поэтому он не отвечает на текущую формулировку.", "Нужны rates publish/deliver/ack, число unacked, age старейшего сообщения, redelivery rate, consumer utilization, disk/memory alarms, confirm latency и connection/channel churn. Depth без входного и выходного rate не показывает, растёт ли backlog. Метрики связывают с SLO времени обработки, а не только с размером очереди." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000094"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда request/reply поверх RabbitMQ является плохим выбором?». Поэтому он не отвечает на текущую формулировку.", "Если вызывающий блокируется в ожидании немедленного ответа, broker добавляет latency, correlation state, timeout и failure modes, но не даёт преимуществ асинхронности. Для короткого запроса часто лучше HTTP/gRPC. Messaging request/reply оправдан при buffering, изоляции или долгом workflow, причём timeout не отменяет уже принятую работу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000101"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что должна делать .NET-служба при автоматическом recovery соединения RabbitMQ?». Поэтому он не отвечает на текущую формулировку.", "Нужно понимать, что старые channels закрыты, in-flight confirms и deliveries имеют неопределённый исход, а topology recovery не восстанавливает внешние side effects. Producer повторяет неподтверждённое с idempotency id, consumer остаётся идемпотентным. Connection и channel lifecycle централизуют, recovery события и время недоступности наблюдают." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000103"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как отличить здоровый backlog от деградации системы?». Поэтому он не отвечает на текущую формулировку.", "Сравнивают arrival rate и sustainable processing rate, возраст старейшего сообщения и прогноз drain time. Плановый burst с уменьшающимся age может быть нормальным, постоянный рост age при насыщенных consumers — деградация. Также проверяют poison loop, downstream latency, prefetch и resource alarms broker." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000104"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как тестировать отказоустойчивость RabbitMQ-интеграции?». Поэтому он не отвечает на текущую формулировку.", "Интеграционные тесты должны убивать consumer после commit до ack, разрывать connection до confirm, давать duplicate/out-of-order payload, заполнять DLQ и имитировать недоступный downstream. Проверяют инварианты и отсутствие потери, а не только happy path. Для quorum queue отдельно тестируют потерю leader и кворума." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000111"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему нельзя совместно использовать один channel между конкурентными publisher без синхронизации?». Поэтому он не отвечает на текущую формулировку.", "AMQP channel — логическая сессия с порядком frames и delivery tags; многие client operations не рассчитаны на конкурентную запись. Перемешивание publish frames или confirm state приводит к protocol errors и неверной корреляции. Используют channel per worker, ограниченный pool или сериализованный publisher согласно гарантиям клиента." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000112"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что происходит при memory или disk alarm в RabbitMQ?». Поэтому он не отвечает на текущую формулировку.", "Broker применяет flow control и блокирует publishing connections, чтобы защитить процесс и данные; consumers обычно могут продолжать дренировать очереди. Producer обязан иметь timeout, bounded buffer и telemetry, иначе блокировка распространится на приложение. Устраняют первопричину capacity/backlog, а не просто повышают порог." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000114"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие данные нужны в message envelope для наблюдаемости и трассировки?». Поэтому он не отвечает на текущую формулировку.", "Минимально: message id, type/version, occurred time, correlation id, causation id и trace context; tenant и actor добавляют только при необходимости и с учётом безопасности. Processing span связывают с publish span, но consumer создаёт новый span link/parent согласно семантике. Payload и персональные данные не логируют без контроля." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000121"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как коррелировать publisher confirms с исходными сообщениями при batch publish?». Поэтому он не отвечает на текущую формулировку.", "Publisher отслеживает monotonically increasing publish sequence number и хранит диапазоны outstanding сообщений. Ack/nack может иметь multiple=true и закрывать все sequence до указанного. Структура должна эффективно удалять диапазон, а при connection loss все оставшиеся считаются неопределёнными и могут быть повторены." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000122"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему health check, который открывает новое соединение на каждый запрос, вреден?». Поэтому он не отвечает на текущую формулировку.", "Создание connection дорого, создаёт churn, нагрузку и может само усугубить отказ. Долгоживущие connections переиспользуют, а health проверяет состояние лёгким способом и различает readiness от liveness. Недоступность broker не всегда должна рестартовать процесс; это зависит от способности сервиса буферизовать или деградировать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000123"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем отличаются direct, topic, fanout и headers exchanges в RabbitMQ?». Поэтому он не отвечает на текущую формулировку.", "Direct маршрутизирует по точному routing key. Topic поддерживает шаблоны с * и #. Fanout отправляет сообщение во все связанные очереди, игнорируя ключ. Headers использует набор заголовков и применяется реже из-за большей сложности и стоимости сопоставления." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000132"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда streams RabbitMQ лучше очередей?». Поэтому он не отвечает на текущую формулировку.", "Stream хранит append-only log, поддерживает replay по offset, несколько независимых читателей и очень большой backlog. Это подходит event log, fan-out и аналитической обработке. Очередь лучше для распределения задач, удаления после ack и сложной routing-семантики; operational модель и client API различаются." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000133"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как настроить graceful shutdown consumer?». Поэтому он не отвечает на текущую формулировку.", "Сначала прекращают принимать новые deliveries или отменяют consumer, затем ждут завершения in-flight в пределах timeout и отправляют ack/nack. Channel закрывают после handlers, connection — последним. Если timeout истёк, незавершённые unacked доставки вернутся в очередь, поэтому обработка обязана быть идемпотентной." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000134"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как обеспечить at-least-once delivery и что должен делать consumer?». Поэтому он не отвечает на текущую формулировку.", "Сообщения публикуют как persistent в durable exchange/queue, используют publisher confirms, а consumer отправляет ack только после успешной обработки. При сбое сообщение доставляется повторно, поэтому consumer обязан быть идемпотентным, например хранить идентификаторы обработанных сообщений или использовать естественный уникальный ключ." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000141"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как partitioning через super streams влияет на порядок сообщений?». Поэтому он не отвечает на текущую формулировку.", "Глобальный порядок теряется, но сохраняется внутри partition. Routing key должен стабильно отправлять связанные события, например одного aggregate id, в одну partition. Число partition определяет параллелизм и стоимость, а consumer group распределяет их между экземплярами; hotspot key всё ещё ограничивает throughput." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000143"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как ограничить размер сообщения и почему большие payload вредны для broker?». Поэтому он не отвечает на текущую формулировку.", "Большие сообщения увеличивают memory, disk I/O, replication traffic, latency и время redelivery. В broker и client задают разумный limit; крупный blob кладут в object storage, а в сообщение — ссылку, checksum и metadata с контролем lifetime и доступа. Компрессия помогает сети, но добавляет CPU и риск decompression bomb." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000144"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое dead-letter exchange и для чего он нужен?». Поэтому он не отвечает на текущую формулировку.", "Dead-letter exchange получает сообщения, которые были rejected/nacked без requeue, истекли по TTL или вытеснены ограничением длины очереди. Он позволяет отделить проблемные сообщения, организовать retry с задержкой и сохранить данные для анализа вместо бесконечного цикла повторной доставки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000151"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать schema evolution сообщений?». Поэтому он не отвечает на текущую формулировку.", "Контракт должен быть backward/forward совместим: добавляют optional поля с defaults, не меняют смысл существующих и версионируют breaking event type. Consumer применяет tolerant reader и тестируется на старых payload. Envelope содержит event type, schema version, id, causation/correlation и occurred time, но не должен скрывать бизнес-семантику." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000152"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать granularity сообщения для пакетной обработки?». Поэтому он не отвечает на текущую формулировку.", "Одно событие должно выражать атомарный бизнес-факт, но transport batch может объединять публикацию или обработку ради throughput. Огромный business batch усложняет retry: одна плохая запись повторяет всё. Если пакет неизбежен, нужна стратегия частичного результата, idempotency каждого элемента и ограничения размера." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000154"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как prefetch влияет на производительность и справедливость распределения сообщений?». Поэтому он не отвечает на текущую формулировку.", "Prefetch ограничивает число неподтверждённых сообщений у consumer. Большое значение повышает throughput, но увеличивает память и может привести к неравномерному распределению. Малое улучшает fairness и время восстановления, но увеличивает влияние сетевых задержек. Значение подбирают по времени обработки и допустимому параллелизму." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000161"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему domain event и integration event не обязаны быть одним типом?». Поэтому он не отвечает на текущую формулировку.", "Domain event отражает внутреннюю модель и может меняться вместе с ней. Integration event — стабильный внешний контракт, минимально раскрывающий данные и часто строящийся после commit. Разделение уменьшает coupling, позволяет обогащать и версионировать сообщение, не публикуя внутренние классы агрегата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000162"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как защититься от duplicate consumer execution одновременно на двух узлах?». Поэтому он не отвечает на текущую формулировку.", "Unique inbox key в БД остаётся источником истины, потому что broker redelivery и network partition допускают конкуренцию. Операцию выполняют в транзакции после успешной вставки ключа либо используют version/unique business constraint. Распределённый lock редко заменяет идемпотентность и добавляет собственные failure modes." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000163"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему порядок сообщений в RabbitMQ нельзя считать абсолютной гарантией?». Поэтому он не отвечает на текущую формулировку.", "Очередь сохраняет порядок публикации, но несколько consumers, повторная доставка, nack/requeue и разное время обработки меняют наблюдаемый порядок завершения. Если порядок критичен, используют один consumer или партиционирование по ключу и контролируют повторную обработку." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000172"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как transactional outbox сочетается с publisher confirms?». Поэтому он не отвечает на текущую формулировку.", "Outbox атомарно сохраняет бизнес-изменение и сообщение в одной БД. Dispatcher публикует его и только после confirm отмечает отправленным; crash между этими действиями создаёт повторный publish. Поэтому outbox предотвращает потерю намерения, confirms подтверждают broker, а idempotent consumer закрывает дубликаты." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000173"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда Single Active Consumer полезен?». Поэтому он не отвечает на текущую формулировку.", "Он даёт активного consumer с автоматическим failover и удобен, когда очередь должна обрабатываться последовательно. Цена — ограниченный throughput и пауза при переключении; порядок всё равно зависит от requeue и publisher routing. Для масштабирования по ключу лучше несколько partition с SAC на каждой." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000174"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем consumer acknowledgements отличаются от publisher confirms и почему нужны оба механизма?». Поэтому он не отвечает на текущую формулировку.", "Ack сообщает broker, что consumer принял ответственность за доставку после успешной обработки. Confirm сообщает publisher, что broker принял ответственность за publish; для quorum queue — после репликации кворумом. Они защищают разные участки пути, а неопределённый исход при разрыве всё равно требует повторной отправки и идемпотентности." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000181"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как масштабировать consumers, сохраняя последовательность событий одного агрегата?». Поэтому он не отвечает на текущую формулировку.", "События маршрутизируют по aggregate id в фиксированную partition/queue и обрабатывают её последовательно одним активным consumer, а разные ключи — параллельно. Альтернатива — version check и буферизация out-of-order, что сложнее. Один глобальный consumer сохраняет порядок, но уничтожает масштабирование." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000183"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как приоритетные очереди влияют на fairness и производительность?». Поэтому он не отвечает на текущую формулировку.", "Приоритет позволяет срочным сообщениям обгонять обычные, но слишком много уровней увеличивает внутренние структуры и CPU. Постоянный поток высокого приоритета может вызвать starvation низкого. Часто прозрачнее иметь несколько очередей с отдельными capacity/SLO и управляемым распределением consumers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000184"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему durable queue и persistent message ещё не гарантируют отсутствие потерь?». Поэтому он не отвечает на текущую формулировку.", "Durable сохраняет определение очереди, persistent просит сохранить сообщение, но publisher не знает, успел ли broker безопасно принять его без confirms. На consumer-side ранний auto-ack также теряет сообщение при crash. Полная схема включает durable replicated queue, publisher confirms, manual ack после side effect и обработку неопределённых исходов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000191"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие метрики RabbitMQ важнее простого queue depth?». Поэтому он не отвечает на текущую формулировку.", "Нужны rates publish/deliver/ack, число unacked, age старейшего сообщения, redelivery rate, consumer utilization, disk/memory alarms, confirm latency и connection/channel churn. Depth без входного и выходного rate не показывает, растёт ли backlog. Метрики связывают с SLO времени обработки, а не только с размером очереди." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000192"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему большое количество очередей и bindings является архитектурным решением, а не бесплатной абстракцией?». Поэтому он не отвечает на текущую формулировку.", "Каждая очередь хранит состояние, метаданные, процессы и метрики; quorum queue добавляет replicas и consensus overhead. Огромная topology увеличивает recovery time и операционную сложность. Разделение делают по независимому backlog, SLA, retention или ownership, а не по каждому типу сообщения автоматически." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000194"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда quorum queue предпочтительнее classic queue?». Поэтому он не отвечает на текущую формулировку.", "Quorum queue нужна для репликации, предсказуемого leader election и высокой сохранности данных; она подтверждает publish после кворума. Цена — дополнительная latency, disk и network overhead, отсутствие transient/exclusive сценариев и ограничения для огромных backlog. Временные очереди, минимальная latency или очень длинные логи могут требовать classic queue или stream." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000201"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как отличить здоровый backlog от деградации системы?». Поэтому он не отвечает на текущую формулировку.", "Сравнивают arrival rate и sustainable processing rate, возраст старейшего сообщения и прогноз drain time. Плановый burst с уменьшающимся age может быть нормальным, постоянный рост age при насыщенных consumers — деградация. Также проверяют poison loop, downstream latency, prefetch и resource alarms broker." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000202"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как отличить команду от события в messaging-контракте?». Поэтому он не отвечает на текущую формулировку.", "Команда выражает намерение конкретному владельцу и может быть отклонена; событие сообщает свершившийся факт и не адресует единственного исполнителя. Название, routing, retry и ожидания ответа различаются. Маскировка команды под событие создаёт скрытую оркестрацию и неясную ответственность." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000203"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что происходит с publish во время недоступности большинства реплик quorum queue?». Поэтому он не отвечает на текущую формулировку.", "Без кворума очередь не может безопасно подтвердить новые записи и сохранить consistency, поэтому publish не получает успешный confirm либо блокируется/завершается ошибкой согласно клиенту и timeout. Система выбирает сохранность данных вместо availability. Producer должен ограниченно повторить неопределённые сообщения после восстановления и не считать timeout доказательством отсутствия записи." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000212"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что происходит при memory или disk alarm в RabbitMQ?». Поэтому он не отвечает на текущую формулировку.", "Broker применяет flow control и блокирует publishing connections, чтобы защитить процесс и данные; consumers обычно могут продолжать дренировать очереди. Producer обязан иметь timeout, bounded buffer и telemetry, иначе блокировка распространится на приложение. Устраняют первопричину capacity/backlog, а не просто повышают порог." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000213"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда request/reply поверх RabbitMQ является плохим выбором?». Поэтому он не отвечает на текущую формулировку.", "Если вызывающий блокируется в ожидании немедленного ответа, broker добавляет latency, correlation state, timeout и failure modes, но не даёт преимуществ асинхронности. Для короткого запроса часто лучше HTTP/gRPC. Messaging request/reply оправдан при buffering, изоляции или долгом workflow, причём timeout не отменяет уже принятую работу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000214"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как спроектировать идемпотентный consumer с базой данных?». Поэтому он не отвечает на текущую формулировку.", "Сообщение получает устойчивый MessageId или business operation id. В одной локальной транзакции consumer фиксирует id в inbox/processed table с unique constraint и применяет изменение; дубликат превращается в no-op. Ack отправляют после commit, а срок хранения ключей выбирают по максимальному окну повторной доставки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000221"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему health check, который открывает новое соединение на каждый запрос, вреден?». Поэтому он не отвечает на текущую формулировку.", "Создание connection дорого, создаёт churn, нагрузку и может само усугубить отказ. Долгоживущие connections переиспользуют, а health проверяет состояние лёгким способом и различает readiness от liveness. Недоступность broker не всегда должна рестартовать процесс; это зависит от способности сервиса буферизовать или деградировать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000223"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как тестировать отказоустойчивость RabbitMQ-интеграции?». Поэтому он не отвечает на текущую формулировку.", "Интеграционные тесты должны убивать consumer после commit до ack, разрывать connection до confirm, давать duplicate/out-of-order payload, заполнять DLQ и имитировать недоступный downstream. Проверяют инварианты и отсутствие потери, а не только happy path. Для quorum queue отдельно тестируют потерю leader и кворума." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000224"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему exactly-once delivery обычно является ложной целью в RabbitMQ-интеграции?». Поэтому он не отвечает на текущую формулировку.", "Broker не может атомарно согласовать ack с произвольным side effect в другой системе. Crash после commit, но до ack, приводит к redelivery; confirm может потеряться после принятого publish. Практическая модель — at-least-once transport плюс идемпотентная обработка, deduplication и бизнес-операции с устойчивым ключом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000231"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как настроить graceful shutdown consumer?». Поэтому он не отвечает на текущую формулировку.", "Сначала прекращают принимать новые deliveries или отменяют consumer, затем ждут завершения in-flight в пределах timeout и отправляют ack/nack. Channel закрывают после handlers, connection — последним. Если timeout истёк, незавершённые unacked доставки вернутся в очередь, поэтому обработка обязана быть идемпотентной." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000232"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие данные нужны в message envelope для наблюдаемости и трассировки?». Поэтому он не отвечает на текущую формулировку.", "Минимально: message id, type/version, occurred time, correlation id, causation id и trace context; tenant и actor добавляют только при необходимости и с учётом безопасности. Processing span связывают с publish span, но consumer создаёт новый span link/parent согласно семантике. Payload и персональные данные не логируют без контроля." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000234"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать prefetch для CPU-bound и I/O-bound consumer?». Поэтому он не отвечает на текущую формулировку.", "Prefetch ограничивает число unacked сообщений на consumer. Для CPU-bound обычно начинают около числа параллельных workers, для I/O-bound допускают больше, учитывая latency и connection limits. Большое значение повышает throughput, но увеличивает memory, время redelivery и несправедливость; настраивают по processing time, backlog и p95." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000241"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как ограничить размер сообщения и почему большие payload вредны для broker?». Поэтому он не отвечает на текущую формулировку.", "Большие сообщения увеличивают memory, disk I/O, replication traffic, latency и время redelivery. В broker и client задают разумный limit; крупный blob кладут в object storage, а в сообщение — ссылку, checksum и metadata с контролем lifetime и доступа. Компрессия помогает сети, но добавляет CPU и риск decompression bomb." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000242"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем отличаются direct, topic, fanout и headers exchanges в RabbitMQ?». Поэтому он не отвечает на текущую формулировку.", "Direct маршрутизирует по точному routing key. Topic поддерживает шаблоны с * и #. Fanout отправляет сообщение во все связанные очереди, игнорируя ключ. Headers использует набор заголовков и применяется реже из-за большей сложности и стоимости сопоставления." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000243"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как retry через nack/requeue может создать hot loop?». Поэтому он не отвечает на текущую формулировку.", "Сообщение немедленно возвращается в ту же очередь и снова попадает тому же или другому consumer, потребляя CPU и network без паузы. Лучше ограничивать попытки, направлять в delay/retry queue с TTL или delayed mechanism и после лимита — в DLQ. Причину и attempt count сохраняют в headers/metadata." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000252"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать granularity сообщения для пакетной обработки?». Поэтому он не отвечает на текущую формулировку.", "Одно событие должно выражать атомарный бизнес-факт, но transport batch может объединять публикацию или обработку ради throughput. Огромный business batch усложняет retry: одна плохая запись повторяет всё. Если пакет неизбежен, нужна стратегия частичного результата, idempotency каждого элемента и ограничения размера." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000253"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как обеспечить at-least-once delivery и что должен делать consumer?». Поэтому он не отвечает на текущую формулировку.", "Сообщения публикуют как persistent в durable exchange/queue, используют publisher confirms, а consumer отправляет ack только после успешной обработки. При сбое сообщение доставляется повторно, поэтому consumer обязан быть идемпотентным, например хранить идентификаторы обработанных сообщений или использовать естественный уникальный ключ." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000254"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какова безопасная модель обработки poison message?». Поэтому он не отвечает на текущую формулировку.", "Consumer различает транзиентную и постоянную ошибку, ограничивает число повторов и переносит неисправимое сообщение в DLQ вместе с причиной и correlation metadata. Нужны alert, инструмент просмотра и контролируемый replay после исправления. Бесконечный requeue скрывает проблему и блокирует полезную нагрузку." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000261"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как защититься от duplicate consumer execution одновременно на двух узлах?». Поэтому он не отвечает на текущую формулировку.", "Unique inbox key в БД остаётся источником истины, потому что broker redelivery и network partition допускают конкуренцию. Операцию выполняют в транзакции после успешной вставки ключа либо используют version/unique business constraint. Распределённый lock редко заменяет идемпотентность и добавляет собственные failure modes." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000263"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое dead-letter exchange и для чего он нужен?». Поэтому он не отвечает на текущую формулировку.", "Dead-letter exchange получает сообщения, которые были rejected/nacked без requeue, истекли по TTL или вытеснены ограничением длины очереди. Он позволяет отделить проблемные сообщения, организовать retry с задержкой и сохранить данные для анализа вместо бесконечного цикла повторной доставки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000264"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие риски у TTL + dead-letter exchange как механизма задержки?». Поэтому он не отвечает на текущую формулировку.", "В classic queue сообщение за большим TTL в голове может задержать истёкшие сообщения позади него, а dead-lettering по умолчанию может иметь weaker guarantees. Создают отдельные retry buckets с фиксированными TTL, контролируют размер и используют quorum at-least-once dead lettering, если нужна сохранность. Для сложного расписания лучше внешний scheduler." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000271"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда Single Active Consumer полезен?». Поэтому он не отвечает на текущую формулировку.", "Он даёт активного consumer с автоматическим failover и удобен, когда очередь должна обрабатываться последовательно. Цена — ограниченный throughput и пауза при переключении; порядок всё равно зависит от requeue и publisher routing. Для масштабирования по ключу лучше несколько partition с SAC на каждой." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000272"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как prefetch влияет на производительность и справедливость распределения сообщений?». Поэтому он не отвечает на текущую формулировку.", "Prefetch ограничивает число неподтверждённых сообщений у consumer. Большое значение повышает throughput, но увеличивает память и может привести к неравномерному распределению. Малое улучшает fairness и время восстановления, но увеличивает влияние сетевых задержек. Значение подбирают по времени обработки и допустимому параллелизму." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000274"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как гарантировать, что unroutable message не исчезнет незаметно?». Поэтому он не отвечает на текущую формулировку.", "Publisher ставит mandatory и обрабатывает basic.return, одновременно используя confirms. Alternate exchange может собирать нерутируемые сообщения, но это другая бизнес-политика и требует мониторинга. Confirm означает принятие broker, а не обязательно попадание в ожидаемую очередь, поэтому оба сигнала различают." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000281"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как приоритетные очереди влияют на fairness и производительность?». Поэтому он не отвечает на текущую формулировку.", "Приоритет позволяет срочным сообщениям обгонять обычные, но слишком много уровней увеличивает внутренние структуры и CPU. Постоянный поток высокого приоритета может вызвать starvation низкого. Часто прозрачнее иметь несколько очередей с отдельными capacity/SLO и управляемым распределением consumers." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000282"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему порядок сообщений в RabbitMQ нельзя считать абсолютной гарантией?». Поэтому он не отвечает на текущую формулировку.", "Очередь сохраняет порядок публикации, но несколько consumers, повторная доставка, nack/requeue и разное время обработки меняют наблюдаемый порядок завершения. Если порядок критичен, используют один consumer или партиционирование по ключу и контролируют повторную обработку." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000283"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что должна делать .NET-служба при автоматическом recovery соединения RabbitMQ?». Поэтому он не отвечает на текущую формулировку.", "Нужно понимать, что старые channels закрыты, in-flight confirms и deliveries имеют неопределённый исход, а topology recovery не восстанавливает внешние side effects. Producer повторяет неподтверждённое с idempotency id, consumer остаётся идемпотентным. Connection и channel lifecycle централизуют, recovery события и время недоступности наблюдают." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000292"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему большое количество очередей и bindings является архитектурным решением, а не бесплатной абстракцией?». Поэтому он не отвечает на текущую формулировку.", "Каждая очередь хранит состояние, метаданные, процессы и метрики; quorum queue добавляет replicas и consensus overhead. Огромная topology увеличивает recovery time и операционную сложность. Разделение делают по независимому backlog, SLA, retention или ownership, а не по каждому типу сообщения автоматически." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000293"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем consumer acknowledgements отличаются от publisher confirms и почему нужны оба механизма?». Поэтому он не отвечает на текущую формулировку.", "Ack сообщает broker, что consumer принял ответственность за доставку после успешной обработки. Confirm сообщает publisher, что broker принял ответственность за publish; для quorum queue — после репликации кворумом. Они защищают разные участки пути, а неопределённый исход при разрыве всё равно требует повторной отправки и идемпотентности." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000294"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему нельзя совместно использовать один channel между конкурентными publisher без синхронизации?». Поэтому он не отвечает на текущую формулировку.", "AMQP channel — логическая сессия с порядком frames и delivery tags; многие client operations не рассчитаны на конкурентную запись. Перемешивание publish frames или confirm state приводит к protocol errors и неверной корреляции. Используют channel per worker, ограниченный pool или сериализованный publisher согласно гарантиям клиента." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000301"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как отличить команду от события в messaging-контракте?». Поэтому он не отвечает на текущую формулировку.", "Команда выражает намерение конкретному владельцу и может быть отклонена; событие сообщает свершившийся факт и не адресует единственного исполнителя. Название, routing, retry и ожидания ответа различаются. Маскировка команды под событие создаёт скрытую оркестрацию и неясную ответственность." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000303"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему durable queue и persistent message ещё не гарантируют отсутствие потерь?». Поэтому он не отвечает на текущую формулировку.", "Durable сохраняет определение очереди, persistent просит сохранить сообщение, но publisher не знает, успел ли broker безопасно принять его без confirms. На consumer-side ранний auto-ack также теряет сообщение при crash. Полная схема включает durable replicated queue, publisher confirms, manual ack после side effect и обработку неопределённых исходов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000304"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как коррелировать publisher confirms с исходными сообщениями при batch publish?». Поэтому он не отвечает на текущую формулировку.", "Publisher отслеживает monotonically increasing publish sequence number и хранит диапазоны outstanding сообщений. Ack/nack может иметь multiple=true и закрывать все sequence до указанного. Структура должна эффективно удалять диапазон, а при connection loss все оставшиеся считаются неопределёнными и могут быть повторены." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000311"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда request/reply поверх RabbitMQ является плохим выбором?». Поэтому он не отвечает на текущую формулировку.", "Если вызывающий блокируется в ожидании немедленного ответа, broker добавляет latency, correlation state, timeout и failure modes, но не даёт преимуществ асинхронности. Для короткого запроса часто лучше HTTP/gRPC. Messaging request/reply оправдан при buffering, изоляции или долгом workflow, причём timeout не отменяет уже принятую работу." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000312"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда quorum queue предпочтительнее classic queue?». Поэтому он не отвечает на текущую формулировку.", "Quorum queue нужна для репликации, предсказуемого leader election и высокой сохранности данных; она подтверждает publish после кворума. Цена — дополнительная latency, disk и network overhead, отсутствие transient/exclusive сценариев и ограничения для огромных backlog. Временные очереди, минимальная latency или очень длинные логи могут требовать classic queue или stream." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000314"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда streams RabbitMQ лучше очередей?». Поэтому он не отвечает на текущую формулировку.", "Stream хранит append-only log, поддерживает replay по offset, несколько независимых читателей и очень большой backlog. Это подходит event log, fan-out и аналитической обработке. Очередь лучше для распределения задач, удаления после ack и сложной routing-семантики; operational модель и client API различаются." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000321"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как тестировать отказоустойчивость RabbitMQ-интеграции?». Поэтому он не отвечает на текущую формулировку.", "Интеграционные тесты должны убивать consumer после commit до ack, разрывать connection до confirm, давать duplicate/out-of-order payload, заполнять DLQ и имитировать недоступный downstream. Проверяют инварианты и отсутствие потери, а не только happy path. Для quorum queue отдельно тестируют потерю leader и кворума." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000322"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что происходит с publish во время недоступности большинства реплик quorum queue?». Поэтому он не отвечает на текущую формулировку.", "Без кворума очередь не может безопасно подтвердить новые записи и сохранить consistency, поэтому publish не получает успешный confirm либо блокируется/завершается ошибкой согласно клиенту и timeout. Система выбирает сохранность данных вместо availability. Producer должен ограниченно повторить неопределённые сообщения после восстановления и не считать timeout доказательством отсутствия записи." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000323"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как partitioning через super streams влияет на порядок сообщений?». Поэтому он не отвечает на текущую формулировку.", "Глобальный порядок теряется, но сохраняется внутри partition. Routing key должен стабильно отправлять связанные события, например одного aggregate id, в одну partition. Число partition определяет параллелизм и стоимость, а consumer group распределяет их между экземплярами; hotspot key всё ещё ограничивает throughput." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000332"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие данные нужны в message envelope для наблюдаемости и трассировки?». Поэтому он не отвечает на текущую формулировку.", "Минимально: message id, type/version, occurred time, correlation id, causation id и trace context; tenant и actor добавляют только при необходимости и с учётом безопасности. Processing span связывают с publish span, но consumer создаёт новый span link/parent согласно семантике. Payload и персональные данные не логируют без контроля." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000333"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как спроектировать идемпотентный consumer с базой данных?». Поэтому он не отвечает на текущую формулировку.", "Сообщение получает устойчивый MessageId или business operation id. В одной локальной транзакции consumer фиксирует id в inbox/processed table с unique constraint и применяет изменение; дубликат превращается в no-op. Ack отправляют после commit, а срок хранения ключей выбирают по максимальному окну повторной доставки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000334"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать schema evolution сообщений?». Поэтому он не отвечает на текущую формулировку.", "Контракт должен быть backward/forward совместим: добавляют optional поля с defaults, не меняют смысл существующих и версионируют breaking event type. Consumer применяет tolerant reader и тестируется на старых payload. Envelope содержит event type, schema version, id, causation/correlation и occurred time, но не должен скрывать бизнес-семантику." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000341"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем отличаются direct, topic, fanout и headers exchanges в RabbitMQ?». Поэтому он не отвечает на текущую формулировку.", "Direct маршрутизирует по точному routing key. Topic поддерживает шаблоны с * и #. Fanout отправляет сообщение во все связанные очереди, игнорируя ключ. Headers использует набор заголовков и применяется реже из-за большей сложности и стоимости сопоставления." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000343"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему exactly-once delivery обычно является ложной целью в RabbitMQ-интеграции?». Поэтому он не отвечает на текущую формулировку.", "Broker не может атомарно согласовать ack с произвольным side effect в другой системе. Crash после commit, но до ack, приводит к redelivery; confirm может потеряться после принятого publish. Практическая модель — at-least-once transport плюс идемпотентная обработка, deduplication и бизнес-операции с устойчивым ключом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000344"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему domain event и integration event не обязаны быть одним типом?». Поэтому он не отвечает на текущую формулировку.", "Domain event отражает внутреннюю модель и может меняться вместе с ней. Integration event — стабильный внешний контракт, минимально раскрывающий данные и часто строящийся после commit. Разделение уменьшает coupling, позволяет обогащать и версионировать сообщение, не публикуя внутренние классы агрегата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000351"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как обеспечить at-least-once delivery и что должен делать consumer?». Поэтому он не отвечает на текущую формулировку.", "Сообщения публикуют как persistent в durable exchange/queue, используют publisher confirms, а consumer отправляет ack только после успешной обработки. При сбое сообщение доставляется повторно, поэтому consumer обязан быть идемпотентным, например хранить идентификаторы обработанных сообщений или использовать естественный уникальный ключ." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000352"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать prefetch для CPU-bound и I/O-bound consumer?». Поэтому он не отвечает на текущую формулировку.", "Prefetch ограничивает число unacked сообщений на consumer. Для CPU-bound обычно начинают около числа параллельных workers, для I/O-bound допускают больше, учитывая latency и connection limits. Большое значение повышает throughput, но увеличивает memory, время redelivery и несправедливость; настраивают по processing time, backlog и p95." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000354"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как transactional outbox сочетается с publisher confirms?». Поэтому он не отвечает на текущую формулировку.", "Outbox атомарно сохраняет бизнес-изменение и сообщение в одной БД. Dispatcher публикует его и только после confirm отмечает отправленным; crash между этими действиями создаёт повторный publish. Поэтому outbox предотвращает потерю намерения, confirms подтверждают broker, а idempotent consumer закрывает дубликаты." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000361"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое dead-letter exchange и для чего он нужен?». Поэтому он не отвечает на текущую формулировку.", "Dead-letter exchange получает сообщения, которые были rejected/nacked без requeue, истекли по TTL или вытеснены ограничением длины очереди. Он позволяет отделить проблемные сообщения, организовать retry с задержкой и сохранить данные для анализа вместо бесконечного цикла повторной доставки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000362"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как retry через nack/requeue может создать hot loop?». Поэтому он не отвечает на текущую формулировку.", "Сообщение немедленно возвращается в ту же очередь и снова попадает тому же или другому consumer, потребляя CPU и network без паузы. Лучше ограничивать попытки, направлять в delay/retry queue с TTL или delayed mechanism и после лимита — в DLQ. Причину и attempt count сохраняют в headers/metadata." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000363"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как масштабировать consumers, сохраняя последовательность событий одного агрегата?». Поэтому он не отвечает на текущую формулировку.", "События маршрутизируют по aggregate id в фиксированную partition/queue и обрабатывают её последовательно одним активным consumer, а разные ключи — параллельно. Альтернатива — version check и буферизация out-of-order, что сложнее. Один глобальный consumer сохраняет порядок, но уничтожает масштабирование." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000372"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как prefetch влияет на производительность и справедливость распределения сообщений?». Поэтому он не отвечает на текущую формулировку.", "Prefetch ограничивает число неподтверждённых сообщений у consumer. Большое значение повышает throughput, но увеличивает память и может привести к неравномерному распределению. Малое улучшает fairness и время восстановления, но увеличивает влияние сетевых задержек. Значение подбирают по времени обработки и допустимому параллелизму." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000373"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какова безопасная модель обработки poison message?». Поэтому он не отвечает на текущую формулировку.", "Consumer различает транзиентную и постоянную ошибку, ограничивает число повторов и переносит неисправимое сообщение в DLQ вместе с причиной и correlation metadata. Нужны alert, инструмент просмотра и контролируемый replay после исправления. Бесконечный requeue скрывает проблему и блокирует полезную нагрузку." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000374"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие метрики RabbitMQ важнее простого queue depth?». Поэтому он не отвечает на текущую формулировку.", "Нужны rates publish/deliver/ack, число unacked, age старейшего сообщения, redelivery rate, consumer utilization, disk/memory alarms, confirm latency и connection/channel churn. Depth без входного и выходного rate не показывает, растёт ли backlog. Метрики связывают с SLO времени обработки, а не только с размером очереди." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000381"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему порядок сообщений в RabbitMQ нельзя считать абсолютной гарантией?». Поэтому он не отвечает на текущую формулировку.", "Очередь сохраняет порядок публикации, но несколько consumers, повторная доставка, nack/requeue и разное время обработки меняют наблюдаемый порядок завершения. Если порядок критичен, используют один consumer или партиционирование по ключу и контролируют повторную обработку." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000383"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие риски у TTL + dead-letter exchange как механизма задержки?». Поэтому он не отвечает на текущую формулировку.", "В classic queue сообщение за большим TTL в голове может задержать истёкшие сообщения позади него, а dead-lettering по умолчанию может иметь weaker guarantees. Создают отдельные retry buckets с фиксированными TTL, контролируют размер и используют quorum at-least-once dead lettering, если нужна сохранность. Для сложного расписания лучше внешний scheduler." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000384"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как отличить здоровый backlog от деградации системы?». Поэтому он не отвечает на текущую формулировку.", "Сравнивают arrival rate и sustainable processing rate, возраст старейшего сообщения и прогноз drain time. Плановый burst с уменьшающимся age может быть нормальным, постоянный рост age при насыщенных consumers — деградация. Также проверяют poison loop, downstream latency, prefetch и resource alarms broker." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000391"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем consumer acknowledgements отличаются от publisher confirms и почему нужны оба механизма?». Поэтому он не отвечает на текущую формулировку.", "Ack сообщает broker, что consumer принял ответственность за доставку после успешной обработки. Confirm сообщает publisher, что broker принял ответственность за publish; для quorum queue — после репликации кворумом. Они защищают разные участки пути, а неопределённый исход при разрыве всё равно требует повторной отправки и идемпотентности." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000392"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как гарантировать, что unroutable message не исчезнет незаметно?». Поэтому он не отвечает на текущую формулировку.", "Publisher ставит mandatory и обрабатывает basic.return, одновременно используя confirms. Alternate exchange может собирать нерутируемые сообщения, но это другая бизнес-политика и требует мониторинга. Confirm означает принятие broker, а не обязательно попадание в ожидаемую очередь, поэтому оба сигнала различают." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000394"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что происходит при memory или disk alarm в RabbitMQ?». Поэтому он не отвечает на текущую формулировку.", "Broker применяет flow control и блокирует publishing connections, чтобы защитить процесс и данные; consumers обычно могут продолжать дренировать очереди. Producer обязан иметь timeout, bounded buffer и telemetry, иначе блокировка распространится на приложение. Устраняют первопричину capacity/backlog, а не просто повышают порог." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000401"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему durable queue и persistent message ещё не гарантируют отсутствие потерь?». Поэтому он не отвечает на текущую формулировку.", "Durable сохраняет определение очереди, persistent просит сохранить сообщение, но publisher не знает, успел ли broker безопасно принять его без confirms. На consumer-side ранний auto-ack также теряет сообщение при crash. Полная схема включает durable replicated queue, publisher confirms, manual ack после side effect и обработку неопределённых исходов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000402"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что должна делать .NET-служба при автоматическом recovery соединения RabbitMQ?». Поэтому он не отвечает на текущую формулировку.", "Нужно понимать, что старые channels закрыты, in-flight confirms и deliveries имеют неопределённый исход, а topology recovery не восстанавливает внешние side effects. Producer повторяет неподтверждённое с idempotency id, consumer остаётся идемпотентным. Connection и channel lifecycle централизуют, recovery события и время недоступности наблюдают." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("41000000-0000-0000-0000-000000000403"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему health check, который открывает новое соединение на каждый запрос, вреден?». Поэтому он не отвечает на текущую формулировку.", "Создание connection дорого, создаёт churn, нагрузку и может само усугубить отказ. Долгоживущие connections переиспользуют, а health проверяет состояние лёгким способом и различает readiness от liveness. Недоступность broker не всегда должна рестартовать процесс; это зависит от способности сервиса буферизовать или деградировать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000012"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое HOT update и как fillfactor влияет на него?». Поэтому он не отвечает на текущую формулировку.", "HOT возможен, когда изменяемые колонки не участвуют в индексах и новая версия строки помещается на той же heap page; тогда не создаются новые записи во всех индексах. Пониженный fillfactor оставляет место для обновлений, уменьшая index bloat, но увеличивает размер таблицы. Эффект проверяют по статистике HOT updates и характеру нагрузки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000013"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему EXPLAIN ANALYZE опасно запускать на изменяющем запросе?». Поэтому он не отвечает на текущую формулировку.", "ANALYZE реально выполняет statement, поэтому UPDATE/DELETE/INSERT изменит данные и может долго блокировать. Его запускают в BEGIN с последующим ROLLBACK, на безопасной копии или используют EXPLAIN без ANALYZE. Даже SELECT с ANALYZE создаёт нагрузку и может повлиять на production latency." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000014"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем streaming replication отличается от logical replication?». Поэтому он не отвечает на текущую формулировку.", "Physical streaming передаёт WAL на уровне кластера, хорошо подходит HA и read replicas той же major-совместимой системы. Logical публикует изменения выбранных таблиц и допускает иной layout/частичные наборы и upgrade-сценарии, но имеет ограничения DDL, sequences и конфликтов. Обе обычно асинхронны и могут отставать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000021"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как составной B-tree индекс связан с порядком колонок и условиями запроса?». Поэтому он не отвечает на текущую формулировку.", "Индекс наиболее эффективен, когда ведущие колонки ограничены equality, затем идёт range/sort; правило не сводится к selectivity одного поля. Он может обслужить left prefix и порядок ORDER BY. Проектирование зависит от реальных predicates, частоты запросов и write cost, а не от создания всех комбинаций." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000023"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как параметризованный prepared statement может получить неудачный generic plan?». Поэтому он не отвечает на текущую формулировку.", "Для распределения с сильным skew оптимальный plan зависит от значения параметра. После нескольких запусков PostgreSQL может выбрать generic plan, средний по стоимости, но плохой для редких значений. Проверяют custom/generic behavior, статистику и при необходимости меняют форму запроса, plan_cache_mode или разделяют сценарии." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000024"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что означают RPO и RTO для PostgreSQL HA?». Поэтому он не отвечает на текущую формулировку.", "RPO — допустимая потеря данных; async replica имеет ненулевой RPO, synchronous commit может приблизить его к нулю ценой latency/availability. RTO — время обнаружения, promotion, routing и восстановления приложения. Репликация без протестированного failover, fencing и backup не даёт полного HA." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000031"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда INCLUDE в PostgreSQL-индексе полезен?». Поэтому он не отвечает на текущую формулировку.", "INCLUDE хранит payload-колонки, не участвующие в поисковом ключе, и может позволить index-only scan без расширения семантики ключа. Цена — больший индекс, больше WAL и стоимость updates. Реальная выгода зависит от visibility map: если heap pages не all-visible, чтение heap всё равно потребуется." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000032"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое lock queue и почему kill блокирующей сессии не всегда первый правильный шаг?». Поэтому он не отвечает на текущую формулировку.", "Ожидающие locks образуют очередь, и одна длинная транзакция может блокировать множество запросов; новые запросы иногда встают за уже ожидающим сильным lock. Сначала находят root blocker, его операцию и возможность безопасного rollback. Kill освобождает locks, но откат может быть долгим и повториться без устранения причины." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000034"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему backup нельзя считать рабочим без restore-теста?». Поэтому он не отвечает на текущую формулировку.", "Успешно записанный архив может быть неполным, несовместимым, повреждённым или не включать нужный WAL для PITR. Регулярный автоматизированный restore проверяет целостность, время восстановления и инструкции. Реплика не заменяет backup, потому что логическое удаление или corruption реплицируется." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000041"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что мешает index-only scan, даже если все нужные колонки есть в индексе?». Поэтому он не отвечает на текущую формулировку.", "MVCC-видимость обычно хранится в heap, поэтому executor проверяет visibility map. Если страницы недавно изменялись и не помечены all-visible после vacuum, приходится читать heap. Также план может выбрать другой путь из-за cost, низкой селективности, размера индекса или устаревшей статистики." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000042"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как диагностировать deadlock и чем он отличается от обычного lock wait?». Поэтому он не отвечает на текущую формулировку.", "Deadlock — цикл ожиданий, который PostgreSQL обнаруживает после deadlock_timeout и прерывает одну транзакцию; обычное ожидание имеет потенциального освобождающего владельца. Анализируют server log, pg_locks, pg_stat_activity и порядок захвата ресурсов. Исправляют единым порядком locks, короткими транзакциями и точными predicates." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000043"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как WAL влияет на write throughput и репликацию?». Поэтому он не отвечает на текущую формулировку.", "Изменения сначала записываются в WAL для durability и recovery, а затем страницы данных сбрасываются отдельно. Большие updates, indexes и full-page images увеличивают объём WAL, I/O и lag replicas. Измеряют WAL generation, checkpoint behavior и network; отключать durability ради скорости можно только при явном принятии потери." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000052"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда partial index лучше полного и какой у него главный подводный камень?». Поэтому он не отвечает на текущую формулировку.", "Partial index полезен для небольшого часто запрашиваемого подмножества, например active rows, уменьшая размер и write cost. Planner использует его только если может доказать, что WHERE запроса подразумевает predicate индекса. Параметризованное или иначе сформулированное условие может помешать доказательству." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000053"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда SELECT FOR UPDATE нужен и какие альтернативы есть для очереди работ?». Поэтому он не отвечает на текущую формулировку.", "Он блокирует выбранные строки от конкурентного изменения и подходит для read-modify-write. Для нескольких workers применяют FOR UPDATE SKIP LOCKED, понимая, что это даёт неполный снимок, но хорошо распределяет jobs. Оптимистичная версия/conditional update может быть лучше при редких конфликтах." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000054"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему слишком частые checkpoints создают latency spikes?». Поэтому он не отвечает на текущую формулировку.", "Checkpoint вынуждает сбрасывать множество dirty pages и после него первые изменения страниц могут генерировать full-page images. Если max_wal_size мал или нагрузка велика, I/O становится bursty. Настраивают checkpoint_timeout, max_wal_size и completion_target, наблюдая write latency и объём WAL." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000061"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Для чего нужны expression indexes и почему функция должна быть подходящей?». Поэтому он не отвечает на текущую формулировку.", "Они индексируют результат выражения, например lower(email), чтобы запрос с тем же выражением использовал B-tree. Выражение должно быть immutable относительно строки; иначе индекс перестанет соответствовать данным. Цена вычисляется при insert/update, а синтаксис запроса должен совпадать распознаваемым образом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000063"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как уровень Serializable реализован в PostgreSQL и что обязан делать клиент?». Поэтому он не отвечает на текущую формулировку.", "PostgreSQL использует Serializable Snapshot Isolation и отслеживает опасные зависимости, не превращая все чтения в blocking locks. При возможной аномалии одна транзакция завершается serialization_failure. Клиент должен повторить всю транзакцию с новым snapshot, ограниченно и только если её внешние side effects безопасны." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000064"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как connection pooling влияет на max_connections и память PostgreSQL?». Поэтому он не отвечает на текущую формулировку.", "Каждое backend connection — процесс с памятью и потенциальным work_mem, поэтому тысячи idle connections дороги. Pooler ограничивает активные backend и мультиплексирует клиентов; transaction pooling несовместим с session state, temp tables и некоторыми prepared statements. Размер пула связывают с CPU и пропускной способностью, а не числом HTTP-запросов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000071"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как extended statistics исправляют ошибки оценки planner?». Поэтому он не отвечает на текущую формулировку.", "Обычная статистика считает колонки в основном независимо, поэтому коррелированные predicates дают ошибочную cardinality. CREATE STATISTICS может собирать dependencies, ndistinct или MCV для группы колонок. Это улучшает выбор join/order, но не заменяет актуальный ANALYZE и не собирает статистику между разными таблицами." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000072"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему Read Committed может видеть разные данные в двух SELECT одной транзакции?». Поэтому он не отвечает на текущую формулировку.", "Каждый statement получает новый snapshot на начало statement, поэтому committed изменения между запросами становятся видимыми. Это нормальная гарантия уровня, а не ошибка MVCC. Если бизнес-инвариант требует стабильного snapshot, используют Repeatable Read/Serializable или формулируют операцию одним atomic statement." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000074"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие проблемы создаёт PgBouncer в transaction pooling mode?». Поэтому он не отвечает на текущую формулировку.", "Клиент получает разные backend между транзакциями, поэтому session-level SET, advisory locks, temp tables, LISTEN и некоторые prepared statement assumptions ломаются. Приложение должно задавать нужное состояние transaction-local или отказаться от этих функций. Это цена высокой эффективности мультиплексирования." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000081"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем nested loop, hash join и merge join отличаются по условиям эффективности?». Поэтому он не отвечает на текущую формулировку.", "Nested loop хорош для малого outer input и индексного поиска во inner. Hash join эффективен для больших equality joins при достаточном work_mem; spill замедляет его. Merge join использует отсортированные входы и полезен для больших упорядочиваемых наборов или range-подобных условий. Решение зависит от оценок cardinality." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000082"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как advisory locks использовать безопасно?». Поэтому он не отвечает на текущую формулировку.", "Они дают application-defined ключ и не привязаны автоматически к строке, поэтому все участники обязаны следовать одному протоколу. Transaction-level locks освобождаются при завершении транзакции и обычно безопаснее session-level. Нужно избегать коллизий ключей, держать lock коротко и не считать его заменой database constraints." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000083"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда BRIN индекс лучше B-tree?». Поэтому он не отвечает на текущую формулировку.", "BRIN хранит summary диапазонов страниц и очень мал, поэтому хорош для огромных append-mostly таблиц, где значение физически коррелирует с порядком, например timestamp. Он возвращает lossy ranges и хуже для случайно распределённых точечных поисков. pages_per_range балансирует размер и точность." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000092"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как work_mem влияет на sort/hash и почему нельзя просто поставить большое значение глобально?». Поэтому он не отвечает на текущую формулировку.", "work_mem применяется на каждый sort/hash node и потенциально на каждого parallel worker, поэтому один запрос может потребить его многократно, а множество сессий — исчерпать RAM. Малое значение вызывает temp spill. Настраивают глобально умеренно, а для известных аналитических операций — локально в транзакции после измерения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000093"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как UPSERT с ON CONFLICT помогает конкурентности и где остаются гонки?». Поэтому он не отвечает на текущую формулировку.", "INSERT ... ON CONFLICT атомарно использует unique constraint для insert/update и устраняет check-then-act race. Но update expression всё равно должен сохранять бизнес-инвариант, а несколько связанных строк требуют транзакции или другого constraint. Неверный conflict target и side effects вне БД остаются проблемой." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000094"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать GIN или GiST для полнотекстового поиска и сложных типов?». Поэтому он не отвечает на текущую формулировку.", "GIN инвертирует элементы и обычно быстрее ищет containment/full-text, но дороже обновляется и может иметь pending list. GiST хранит обобщённое дерево, поддерживает distance/nearest-neighbor и разные операторные классы, часто с lossy recheck. Выбор определяется операторами, update rate и измерением." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000101"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что означает Rows Removed by Filter в EXPLAIN ANALYZE?». Поэтому он не отвечает на текущую формулировку.", "Это число строк, прочитанных узлом, но отброшенных его filter; большое значение может указывать на плохой access path или отсутствующий подходящий индекс. Однако для маленькой таблицы sequential scan может быть дешевле. Смотрят actual loops, buffers, время и отношение estimated к actual rows в контексте всего плана." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000103"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать partition key для большой таблицы?». Поэтому он не отвечает на текущую формулировку.", "Ключ должен поддерживать pruning основных запросов, lifecycle данных и равномерное распределение. Временной range удобен для retention, hash — для распределения, list — для ограниченных доменов. Слишком много partition увеличивает planning/metadata overhead, а unique constraint обычно должен включать partition key." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000104"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему изменение типа колонки может заблокировать таблицу надолго?». Поэтому он не отвечает на текущую формулировку.", "Если conversion требует rewrite, PostgreSQL переписывает все строки под сильной блокировкой и генерирует WAL. Для большой таблицы применяют expand-contract: новую колонку, backfill batches, dual write, проверку и переключение. Некоторые бинарно совместимые изменения metadata-only, но это проверяют для конкретной версии." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000111"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему EXPLAIN ANALYZE опасно запускать на изменяющем запросе?». Поэтому он не отвечает на текущую формулировку.", "ANALYZE реально выполняет statement, поэтому UPDATE/DELETE/INSERT изменит данные и может долго блокировать. Его запускают в BEGIN с последующим ROLLBACK, на безопасной копии или используют EXPLAIN без ANALYZE. Даже SELECT с ANALYZE создаёт нагрузку и может повлиять на production latency." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000112"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему partitioning не является универсальным способом ускорить запросы?». Поэтому он не отвечает на текущую формулировку.", "Она помогает, когда pruning исключает большую часть данных или облегчает maintenance, но запросы по другому ключу могут читать все partitions. Индексы всё равно нужны, joins и planning усложняются, skew создаёт hot partition. Сначала подтверждают проблему размера, retention или contention." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000114"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как расследовать внезапное ухудшение плана после роста данных?». Поэтому он не отвечает на текущую формулировку.", "Сравнивают старый и новый plan, estimated/actual rows, статистику и распределение значений; проверяют ANALYZE, bloat, новые параметры и generic plans. Увеличивают statistics target для skewed колонок или создают extended statistics, затем исправляют запрос/индекс. Принудительный hint-подход не заменяет корректную модель cost." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000121"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как параметризованный prepared statement может получить неудачный generic plan?». Поэтому он не отвечает на текущую формулировку.", "Для распределения с сильным skew оптимальный plan зависит от значения параметра. После нескольких запусков PostgreSQL может выбрать generic plan, средний по стоимости, но плохой для редких значений. Проверяют custom/generic behavior, статистику и при необходимости меняют форму запроса, plan_cache_mode или разделяют сценарии." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000122"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как безопасно удалять старые данные из очень большой временной таблицы?». Поэтому он не отвечает на текущую формулировку.", "Если таблица partitioned по времени, detach/drop старой partition почти мгновенно освобождает логический объём и избегает миллионов row deletes/WAL. Без partitioning удаляют небольшими batches с паузами и vacuum, контролируя replicas и locks. Большая одиночная DELETE создаёт bloat и длительную транзакцию." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000123"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как MVCC работает в PostgreSQL и зачем нужен VACUUM?». Поэтому он не отвечает на текущую формулировку.", "MVCC хранит несколько версий строк, позволяя читателям и писателям меньше блокировать друг друга. UPDATE создаёт новую версию, а старая становится dead tuple после завершения видимых транзакций. VACUUM освобождает место для повторного использования и предотвращает переполнение transaction ID; autovacuum автоматизирует процесс." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000132"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое lock queue и почему kill блокирующей сессии не всегда первый правильный шаг?». Поэтому он не отвечает на текущую формулировку.", "Ожидающие locks образуют очередь, и одна длинная транзакция может блокировать множество запросов; новые запросы иногда встают за уже ожидающим сильным lock. Сначала находят root blocker, его операцию и возможность безопасного rollback. Kill освобождает locks, но откат может быть долгим и повториться без устранения причины." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000133"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем streaming replication отличается от logical replication?». Поэтому он не отвечает на текущую формулировку.", "Physical streaming передаёт WAL на уровне кластера, хорошо подходит HA и read replicas той же major-совместимой системы. Logical публикует изменения выбранных таблиц и допускает иной layout/частичные наборы и upgrade-сценарии, но имеет ограничения DDL, sequences и конфликтов. Обе обычно асинхронны и могут отставать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000134"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «В чём разница между B-tree, Hash, GIN и GiST индексами?». Поэтому он не отвечает на текущую формулировку.", "B-tree — универсальный выбор для равенства, диапазонов и сортировки. Hash оптимизирован для равенства, но обычно не даёт преимуществ над B-tree. GIN эффективен для составных значений, массивов, JSONB и полнотекстового поиска. GiST поддерживает расширяемые стратегии, геометрию, диапазоны и nearest-neighbor поиск." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000141"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как диагностировать deadlock и чем он отличается от обычного lock wait?». Поэтому он не отвечает на текущую формулировку.", "Deadlock — цикл ожиданий, который PostgreSQL обнаруживает после deadlock_timeout и прерывает одну транзакцию; обычное ожидание имеет потенциального освобождающего владельца. Анализируют server log, pg_locks, pg_stat_activity и порядок захвата ресурсов. Исправляют единым порядком locks, короткими транзакциями и точными predicates." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000143"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что означают RPO и RTO для PostgreSQL HA?». Поэтому он не отвечает на текущую формулировку.", "RPO — допустимая потеря данных; async replica имеет ненулевой RPO, synchronous commit может приблизить его к нулю ценой latency/availability. RTO — время обнаружения, promotion, routing и восстановления приложения. Репликация без протестированного failover, fencing и backup не даёт полного HA." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000144"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как читать EXPLAIN ANALYZE и какие признаки указывают на проблему?». Поэтому он не отвечает на текущую формулировку.", "Сравнивают estimated и actual rows, время узлов, число loops, способ доступа и операции сортировки/хеширования. Большие расхождения строк указывают на устаревшую статистику или коррелированные данные. Seq Scan не всегда плох: он разумен для маленькой таблицы или выборки большой доли строк." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000151"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда SELECT FOR UPDATE нужен и какие альтернативы есть для очереди работ?». Поэтому он не отвечает на текущую формулировку.", "Он блокирует выбранные строки от конкурентного изменения и подходит для read-modify-write. Для нескольких workers применяют FOR UPDATE SKIP LOCKED, понимая, что это даёт неполный снимок, но хорошо распределяет jobs. Оптимистичная версия/conditional update может быть лучше при редких конфликтах." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000152"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему backup нельзя считать рабочим без restore-теста?». Поэтому он не отвечает на текущую формулировку.", "Успешно записанный архив может быть неполным, несовместимым, повреждённым или не включать нужный WAL для PITR. Регулярный автоматизированный restore проверяет целостность, время восстановления и инструкции. Реплика не заменяет backup, потому что логическое удаление или corruption реплицируется." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000154"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие уровни изоляции транзакций поддерживает PostgreSQL и когда нужен Serializable?». Поэтому он не отвечает на текущую формулировку.", "PostgreSQL предоставляет Read Committed, Repeatable Read и Serializable; Read Uncommitted ведёт себя как Read Committed. Serializable нужен, когда результат параллельных транзакций должен быть эквивалентен последовательному выполнению. Он может завершить транзакцию serialization failure, поэтому приложение обязано поддерживать retry." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000161"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как уровень Serializable реализован в PostgreSQL и что обязан делать клиент?». Поэтому он не отвечает на текущую формулировку.", "PostgreSQL использует Serializable Snapshot Isolation и отслеживает опасные зависимости, не превращая все чтения в blocking locks. При возможной аномалии одна транзакция завершается serialization_failure. Клиент должен повторить всю транзакцию с новым snapshot, ограниченно и только если её внешние side effects безопасны." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000162"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как WAL влияет на write throughput и репликацию?». Поэтому он не отвечает на текущую формулировку.", "Изменения сначала записываются в WAL для durability и recovery, а затем страницы данных сбрасываются отдельно. Большие updates, indexes и full-page images увеличивают объём WAL, I/O и lag replicas. Измеряют WAL generation, checkpoint behavior и network; отключать durability ради скорости можно только при явном принятии потери." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000163"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему индекс может не использоваться планировщиком PostgreSQL?». Поэтому он не отвечает на текущую формулировку.", "Последовательное чтение может быть дешевле для маленькой таблицы или низкой селективности. Причинами также бывают несовместимое выражение или преобразование типа, устаревшая статистика, ведущий wildcard, неподходящий порядок составного индекса и функции без соответствующего expression index." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000172"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему Read Committed может видеть разные данные в двух SELECT одной транзакции?». Поэтому он не отвечает на текущую формулировку.", "Каждый statement получает новый snapshot на начало statement, поэтому committed изменения между запросами становятся видимыми. Это нормальная гарантия уровня, а не ошибка MVCC. Если бизнес-инвариант требует стабильного snapshot, используют Repeatable Read/Serializable или формулируют операцию одним atomic statement." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000173"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему слишком частые checkpoints создают latency spikes?». Поэтому он не отвечает на текущую формулировку.", "Checkpoint вынуждает сбрасывать множество dirty pages и после него первые изменения страниц могут генерировать full-page images. Если max_wal_size мал или нагрузка велика, I/O становится bursty. Настраивают checkpoint_timeout, max_wal_size и completion_target, наблюдая write latency и объём WAL." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000174"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему длинная транзакция мешает VACUUM и чем это проявляется?». Поэтому он не отвечает на текущую формулировку.", "Долгая transaction snapshot удерживает xmin, поэтому версии строк, потенциально видимые ей, нельзя удалить. Dead tuples накапливаются, таблицы и индексы раздуваются, планы и I/O ухудшаются, а wraparound risk растёт. Ищут age транзакций и idle in transaction sessions, ограничивают timeout и сокращают бизнес-операции внутри транзакции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000181"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как advisory locks использовать безопасно?». Поэтому он не отвечает на текущую формулировку.", "Они дают application-defined ключ и не привязаны автоматически к строке, поэтому все участники обязаны следовать одному протоколу. Transaction-level locks освобождаются при завершении транзакции и обычно безопаснее session-level. Нужно избегать коллизий ключей, держать lock коротко и не считать его заменой database constraints." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000183"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как connection pooling влияет на max_connections и память PostgreSQL?». Поэтому он не отвечает на текущую формулировку.", "Каждое backend connection — процесс с памятью и потенциальным work_mem, поэтому тысячи idle connections дороги. Pooler ограничивает активные backend и мультиплексирует клиентов; transaction pooling несовместим с session state, temp tables и некоторыми prepared statements. Размер пула связывают с CPU и пропускной способностью, а не числом HTTP-запросов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000184"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем VACUUM, VACUUM FULL и autovacuum отличаются по назначению?». Поэтому он не отвечает на текущую формулировку.", "Обычный VACUUM помечает место reusable и обновляет visibility map без возврата файла ОС; он допускает параллельную работу. VACUUM FULL переписывает таблицу, возвращает место, но берёт сильную блокировку. Autovacuum выполняет регулярную очистку/analyze и anti-wraparound; его чаще настраивают, а не отключают." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000191"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как UPSERT с ON CONFLICT помогает конкурентности и где остаются гонки?». Поэтому он не отвечает на текущую формулировку.", "INSERT ... ON CONFLICT атомарно использует unique constraint для insert/update и устраняет check-then-act race. Но update expression всё равно должен сохранять бизнес-инвариант, а несколько связанных строк требуют транзакции или другого constraint. Неверный conflict target и side effects вне БД остаются проблемой." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000192"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие проблемы создаёт PgBouncer в transaction pooling mode?». Поэтому он не отвечает на текущую формулировку.", "Клиент получает разные backend между транзакциями, поэтому session-level SET, advisory locks, temp tables, LISTEN и некоторые prepared statement assumptions ломаются. Приложение должно задавать нужное состояние transaction-local или отказаться от этих функций. Это цена высокой эффективности мультиплексирования." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000194"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое HOT update и как fillfactor влияет на него?». Поэтому он не отвечает на текущую формулировку.", "HOT возможен, когда изменяемые колонки не участвуют в индексах и новая версия строки помещается на той же heap page; тогда не создаются новые записи во всех индексах. Пониженный fillfactor оставляет место для обновлений, уменьшая index bloat, но увеличивает размер таблицы. Эффект проверяют по статистике HOT updates и характеру нагрузки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000201"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать partition key для большой таблицы?». Поэтому он не отвечает на текущую формулировку.", "Ключ должен поддерживать pruning основных запросов, lifecycle данных и равномерное распределение. Временной range удобен для retention, hash — для распределения, list — для ограниченных доменов. Слишком много partition увеличивает planning/metadata overhead, а unique constraint обычно должен включать partition key." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000202"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда BRIN индекс лучше B-tree?». Поэтому он не отвечает на текущую формулировку.", "BRIN хранит summary диапазонов страниц и очень мал, поэтому хорош для огромных append-mostly таблиц, где значение физически коррелирует с порядком, например timestamp. Он возвращает lossy ranges и хуже для случайно распределённых точечных поисков. pages_per_range балансирует размер и точность." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000203"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как составной B-tree индекс связан с порядком колонок и условиями запроса?». Поэтому он не отвечает на текущую формулировку.", "Индекс наиболее эффективен, когда ведущие колонки ограничены equality, затем идёт range/sort; правило не сводится к selectivity одного поля. Он может обслужить left prefix и порядок ORDER BY. Проектирование зависит от реальных predicates, частоты запросов и write cost, а не от создания всех комбинаций." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000212"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему partitioning не является универсальным способом ускорить запросы?». Поэтому он не отвечает на текущую формулировку.", "Она помогает, когда pruning исключает большую часть данных или облегчает maintenance, но запросы по другому ключу могут читать все partitions. Индексы всё равно нужны, joins и planning усложняются, skew создаёт hot partition. Сначала подтверждают проблему размера, retention или contention." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000213"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать GIN или GiST для полнотекстового поиска и сложных типов?». Поэтому он не отвечает на текущую формулировку.", "GIN инвертирует элементы и обычно быстрее ищет containment/full-text, но дороже обновляется и может иметь pending list. GiST хранит обобщённое дерево, поддерживает distance/nearest-neighbor и разные операторные классы, часто с lossy recheck. Выбор определяется операторами, update rate и измерением." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000214"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда INCLUDE в PostgreSQL-индексе полезен?». Поэтому он не отвечает на текущую формулировку.", "INCLUDE хранит payload-колонки, не участвующие в поисковом ключе, и может позволить index-only scan без расширения семантики ключа. Цена — больший индекс, больше WAL и стоимость updates. Реальная выгода зависит от visibility map: если heap pages не all-visible, чтение heap всё равно потребуется." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000221"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как безопасно удалять старые данные из очень большой временной таблицы?». Поэтому он не отвечает на текущую формулировку.", "Если таблица partitioned по времени, detach/drop старой partition почти мгновенно освобождает логический объём и избегает миллионов row deletes/WAL. Без partitioning удаляют небольшими batches с паузами и vacuum, контролируя replicas и locks. Большая одиночная DELETE создаёт bloat и длительную транзакцию." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000223"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему изменение типа колонки может заблокировать таблицу надолго?». Поэтому он не отвечает на текущую формулировку.", "Если conversion требует rewrite, PostgreSQL переписывает все строки под сильной блокировкой и генерирует WAL. Для большой таблицы применяют expand-contract: новую колонку, backfill batches, dual write, проверку и переключение. Некоторые бинарно совместимые изменения metadata-only, но это проверяют для конкретной версии." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000224"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что мешает index-only scan, даже если все нужные колонки есть в индексе?». Поэтому он не отвечает на текущую формулировку.", "MVCC-видимость обычно хранится в heap, поэтому executor проверяет visibility map. Если страницы недавно изменялись и не помечены all-visible после vacuum, приходится читать heap. Также план может выбрать другой путь из-за cost, низкой селективности, размера индекса или устаревшей статистики." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000231"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем streaming replication отличается от logical replication?». Поэтому он не отвечает на текущую формулировку.", "Physical streaming передаёт WAL на уровне кластера, хорошо подходит HA и read replicas той же major-совместимой системы. Logical публикует изменения выбранных таблиц и допускает иной layout/частичные наборы и upgrade-сценарии, но имеет ограничения DDL, sequences и конфликтов. Обе обычно асинхронны и могут отставать." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000232"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как расследовать внезапное ухудшение плана после роста данных?». Поэтому он не отвечает на текущую формулировку.", "Сравнивают старый и новый plan, estimated/actual rows, статистику и распределение значений; проверяют ANALYZE, bloat, новые параметры и generic plans. Увеличивают statistics target для skewed колонок или создают extended statistics, затем исправляют запрос/индекс. Принудительный hint-подход не заменяет корректную модель cost." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000234"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда partial index лучше полного и какой у него главный подводный камень?». Поэтому он не отвечает на текущую формулировку.", "Partial index полезен для небольшого часто запрашиваемого подмножества, например active rows, уменьшая размер и write cost. Planner использует его только если может доказать, что WHERE запроса подразумевает predicate индекса. Параметризованное или иначе сформулированное условие может помешать доказательству." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000241"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что означают RPO и RTO для PostgreSQL HA?». Поэтому он не отвечает на текущую формулировку.", "RPO — допустимая потеря данных; async replica имеет ненулевой RPO, synchronous commit может приблизить его к нулю ценой latency/availability. RTO — время обнаружения, promotion, routing и восстановления приложения. Репликация без протестированного failover, fencing и backup не даёт полного HA." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000242"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как MVCC работает в PostgreSQL и зачем нужен VACUUM?». Поэтому он не отвечает на текущую формулировку.", "MVCC хранит несколько версий строк, позволяя читателям и писателям меньше блокировать друг друга. UPDATE создаёт новую версию, а старая становится dead tuple после завершения видимых транзакций. VACUUM освобождает место для повторного использования и предотвращает переполнение transaction ID; autovacuum автоматизирует процесс." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000243"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Для чего нужны expression indexes и почему функция должна быть подходящей?». Поэтому он не отвечает на текущую формулировку.", "Они индексируют результат выражения, например lower(email), чтобы запрос с тем же выражением использовал B-tree. Выражение должно быть immutable относительно строки; иначе индекс перестанет соответствовать данным. Цена вычисляется при insert/update, а синтаксис запроса должен совпадать распознаваемым образом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000252"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему backup нельзя считать рабочим без restore-теста?». Поэтому он не отвечает на текущую формулировку.", "Успешно записанный архив может быть неполным, несовместимым, повреждённым или не включать нужный WAL для PITR. Регулярный автоматизированный restore проверяет целостность, время восстановления и инструкции. Реплика не заменяет backup, потому что логическое удаление или corruption реплицируется." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000253"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «В чём разница между B-tree, Hash, GIN и GiST индексами?». Поэтому он не отвечает на текущую формулировку.", "B-tree — универсальный выбор для равенства, диапазонов и сортировки. Hash оптимизирован для равенства, но обычно не даёт преимуществ над B-tree. GIN эффективен для составных значений, массивов, JSONB и полнотекстового поиска. GiST поддерживает расширяемые стратегии, геометрию, диапазоны и nearest-neighbor поиск." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000254"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как extended statistics исправляют ошибки оценки planner?». Поэтому он не отвечает на текущую формулировку.", "Обычная статистика считает колонки в основном независимо, поэтому коррелированные predicates дают ошибочную cardinality. CREATE STATISTICS может собирать dependencies, ndistinct или MCV для группы колонок. Это улучшает выбор join/order, но не заменяет актуальный ANALYZE и не собирает статистику между разными таблицами." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000261"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как WAL влияет на write throughput и репликацию?». Поэтому он не отвечает на текущую формулировку.", "Изменения сначала записываются в WAL для durability и recovery, а затем страницы данных сбрасываются отдельно. Большие updates, indexes и full-page images увеличивают объём WAL, I/O и lag replicas. Измеряют WAL generation, checkpoint behavior и network; отключать durability ради скорости можно только при явном принятии потери." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000263"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как читать EXPLAIN ANALYZE и какие признаки указывают на проблему?». Поэтому он не отвечает на текущую формулировку.", "Сравнивают estimated и actual rows, время узлов, число loops, способ доступа и операции сортировки/хеширования. Большие расхождения строк указывают на устаревшую статистику или коррелированные данные. Seq Scan не всегда плох: он разумен для маленькой таблицы или выборки большой доли строк." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000264"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем nested loop, hash join и merge join отличаются по условиям эффективности?». Поэтому он не отвечает на текущую формулировку.", "Nested loop хорош для малого outer input и индексного поиска во inner. Hash join эффективен для больших equality joins при достаточном work_mem; spill замедляет его. Merge join использует отсортированные входы и полезен для больших упорядочиваемых наборов или range-подобных условий. Решение зависит от оценок cardinality." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000271"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему слишком частые checkpoints создают latency spikes?». Поэтому он не отвечает на текущую формулировку.", "Checkpoint вынуждает сбрасывать множество dirty pages и после него первые изменения страниц могут генерировать full-page images. Если max_wal_size мал или нагрузка велика, I/O становится bursty. Настраивают checkpoint_timeout, max_wal_size и completion_target, наблюдая write latency и объём WAL." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000272"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие уровни изоляции транзакций поддерживает PostgreSQL и когда нужен Serializable?». Поэтому он не отвечает на текущую формулировку.", "PostgreSQL предоставляет Read Committed, Repeatable Read и Serializable; Read Uncommitted ведёт себя как Read Committed. Serializable нужен, когда результат параллельных транзакций должен быть эквивалентен последовательному выполнению. Он может завершить транзакцию serialization failure, поэтому приложение обязано поддерживать retry." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000274"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как work_mem влияет на sort/hash и почему нельзя просто поставить большое значение глобально?». Поэтому он не отвечает на текущую формулировку.", "work_mem применяется на каждый sort/hash node и потенциально на каждого parallel worker, поэтому один запрос может потребить его многократно, а множество сессий — исчерпать RAM. Малое значение вызывает temp spill. Настраивают глобально умеренно, а для известных аналитических операций — локально в транзакции после измерения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000281"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как connection pooling влияет на max_connections и память PostgreSQL?». Поэтому он не отвечает на текущую формулировку.", "Каждое backend connection — процесс с памятью и потенциальным work_mem, поэтому тысячи idle connections дороги. Pooler ограничивает активные backend и мультиплексирует клиентов; transaction pooling несовместим с session state, temp tables и некоторыми prepared statements. Размер пула связывают с CPU и пропускной способностью, а не числом HTTP-запросов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000282"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему индекс может не использоваться планировщиком PostgreSQL?». Поэтому он не отвечает на текущую формулировку.", "Последовательное чтение может быть дешевле для маленькой таблицы или низкой селективности. Причинами также бывают несовместимое выражение или преобразование типа, устаревшая статистика, ведущий wildcard, неподходящий порядок составного индекса и функции без соответствующего expression index." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000283"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что означает Rows Removed by Filter в EXPLAIN ANALYZE?». Поэтому он не отвечает на текущую формулировку.", "Это число строк, прочитанных узлом, но отброшенных его filter; большое значение может указывать на плохой access path или отсутствующий подходящий индекс. Однако для маленькой таблицы sequential scan может быть дешевле. Смотрят actual loops, buffers, время и отношение estimated к actual rows в контексте всего плана." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000292"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие проблемы создаёт PgBouncer в transaction pooling mode?». Поэтому он не отвечает на текущую формулировку.", "Клиент получает разные backend между транзакциями, поэтому session-level SET, advisory locks, temp tables, LISTEN и некоторые prepared statement assumptions ломаются. Приложение должно задавать нужное состояние transaction-local или отказаться от этих функций. Это цена высокой эффективности мультиплексирования." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000293"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему длинная транзакция мешает VACUUM и чем это проявляется?». Поэтому он не отвечает на текущую формулировку.", "Долгая transaction snapshot удерживает xmin, поэтому версии строк, потенциально видимые ей, нельзя удалить. Dead tuples накапливаются, таблицы и индексы раздуваются, планы и I/O ухудшаются, а wraparound risk растёт. Ищут age транзакций и idle in transaction sessions, ограничивают timeout и сокращают бизнес-операции внутри транзакции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000294"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему EXPLAIN ANALYZE опасно запускать на изменяющем запросе?». Поэтому он не отвечает на текущую формулировку.", "ANALYZE реально выполняет statement, поэтому UPDATE/DELETE/INSERT изменит данные и может долго блокировать. Его запускают в BEGIN с последующим ROLLBACK, на безопасной копии или используют EXPLAIN без ANALYZE. Даже SELECT с ANALYZE создаёт нагрузку и может повлиять на production latency." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000301"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда BRIN индекс лучше B-tree?». Поэтому он не отвечает на текущую формулировку.", "BRIN хранит summary диапазонов страниц и очень мал, поэтому хорош для огромных append-mostly таблиц, где значение физически коррелирует с порядком, например timestamp. Он возвращает lossy ranges и хуже для случайно распределённых точечных поисков. pages_per_range балансирует размер и точность." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000303"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем VACUUM, VACUUM FULL и autovacuum отличаются по назначению?». Поэтому он не отвечает на текущую формулировку.", "Обычный VACUUM помечает место reusable и обновляет visibility map без возврата файла ОС; он допускает параллельную работу. VACUUM FULL переписывает таблицу, возвращает место, но берёт сильную блокировку. Autovacuum выполняет регулярную очистку/analyze и anti-wraparound; его чаще настраивают, а не отключают." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000304"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как параметризованный prepared statement может получить неудачный generic plan?». Поэтому он не отвечает на текущую формулировку.", "Для распределения с сильным skew оптимальный plan зависит от значения параметра. После нескольких запусков PostgreSQL может выбрать generic plan, средний по стоимости, но плохой для редких значений. Проверяют custom/generic behavior, статистику и при необходимости меняют форму запроса, plan_cache_mode или разделяют сценарии." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000311"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать GIN или GiST для полнотекстового поиска и сложных типов?». Поэтому он не отвечает на текущую формулировку.", "GIN инвертирует элементы и обычно быстрее ищет containment/full-text, но дороже обновляется и может иметь pending list. GiST хранит обобщённое дерево, поддерживает distance/nearest-neighbor и разные операторные классы, часто с lossy recheck. Выбор определяется операторами, update rate и измерением." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000312"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое HOT update и как fillfactor влияет на него?». Поэтому он не отвечает на текущую формулировку.", "HOT возможен, когда изменяемые колонки не участвуют в индексах и новая версия строки помещается на той же heap page; тогда не создаются новые записи во всех индексах. Пониженный fillfactor оставляет место для обновлений, уменьшая index bloat, но увеличивает размер таблицы. Эффект проверяют по статистике HOT updates и характеру нагрузки." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000314"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое lock queue и почему kill блокирующей сессии не всегда первый правильный шаг?». Поэтому он не отвечает на текущую формулировку.", "Ожидающие locks образуют очередь, и одна длинная транзакция может блокировать множество запросов; новые запросы иногда встают за уже ожидающим сильным lock. Сначала находят root blocker, его операцию и возможность безопасного rollback. Kill освобождает locks, но откат может быть долгим и повториться без устранения причины." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000321"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему изменение типа колонки может заблокировать таблицу надолго?». Поэтому он не отвечает на текущую формулировку.", "Если conversion требует rewrite, PostgreSQL переписывает все строки под сильной блокировкой и генерирует WAL. Для большой таблицы применяют expand-contract: новую колонку, backfill batches, dual write, проверку и переключение. Некоторые бинарно совместимые изменения metadata-only, но это проверяют для конкретной версии." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000322"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как составной B-tree индекс связан с порядком колонок и условиями запроса?». Поэтому он не отвечает на текущую формулировку.", "Индекс наиболее эффективен, когда ведущие колонки ограничены equality, затем идёт range/sort; правило не сводится к selectivity одного поля. Он может обслужить left prefix и порядок ORDER BY. Проектирование зависит от реальных predicates, частоты запросов и write cost, а не от создания всех комбинаций." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000323"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как диагностировать deadlock и чем он отличается от обычного lock wait?». Поэтому он не отвечает на текущую формулировку.", "Deadlock — цикл ожиданий, который PostgreSQL обнаруживает после deadlock_timeout и прерывает одну транзакцию; обычное ожидание имеет потенциального освобождающего владельца. Анализируют server log, pg_locks, pg_stat_activity и порядок захвата ресурсов. Исправляют единым порядком locks, короткими транзакциями и точными predicates." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000332"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как расследовать внезапное ухудшение плана после роста данных?». Поэтому он не отвечает на текущую формулировку.", "Сравнивают старый и новый plan, estimated/actual rows, статистику и распределение значений; проверяют ANALYZE, bloat, новые параметры и generic plans. Увеличивают statistics target для skewed колонок или создают extended statistics, затем исправляют запрос/индекс. Принудительный hint-подход не заменяет корректную модель cost." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000333"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда INCLUDE в PostgreSQL-индексе полезен?». Поэтому он не отвечает на текущую формулировку.", "INCLUDE хранит payload-колонки, не участвующие в поисковом ключе, и может позволить index-only scan без расширения семантики ключа. Цена — больший индекс, больше WAL и стоимость updates. Реальная выгода зависит от visibility map: если heap pages не all-visible, чтение heap всё равно потребуется." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000334"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда SELECT FOR UPDATE нужен и какие альтернативы есть для очереди работ?». Поэтому он не отвечает на текущую формулировку.", "Он блокирует выбранные строки от конкурентного изменения и подходит для read-modify-write. Для нескольких workers применяют FOR UPDATE SKIP LOCKED, понимая, что это даёт неполный снимок, но хорошо распределяет jobs. Оптимистичная версия/conditional update может быть лучше при редких конфликтах." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000341"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как MVCC работает в PostgreSQL и зачем нужен VACUUM?». Поэтому он не отвечает на текущую формулировку.", "MVCC хранит несколько версий строк, позволяя читателям и писателям меньше блокировать друг друга. UPDATE создаёт новую версию, а старая становится dead tuple после завершения видимых транзакций. VACUUM освобождает место для повторного использования и предотвращает переполнение transaction ID; autovacuum автоматизирует процесс." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000343"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что мешает index-only scan, даже если все нужные колонки есть в индексе?». Поэтому он не отвечает на текущую формулировку.", "MVCC-видимость обычно хранится в heap, поэтому executor проверяет visibility map. Если страницы недавно изменялись и не помечены all-visible после vacuum, приходится читать heap. Также план может выбрать другой путь из-за cost, низкой селективности, размера индекса или устаревшей статистики." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000344"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как уровень Serializable реализован в PostgreSQL и что обязан делать клиент?». Поэтому он не отвечает на текущую формулировку.", "PostgreSQL использует Serializable Snapshot Isolation и отслеживает опасные зависимости, не превращая все чтения в blocking locks. При возможной аномалии одна транзакция завершается serialization_failure. Клиент должен повторить всю транзакцию с новым snapshot, ограниченно и только если её внешние side effects безопасны." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000351"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «В чём разница между B-tree, Hash, GIN и GiST индексами?». Поэтому он не отвечает на текущую формулировку.", "B-tree — универсальный выбор для равенства, диапазонов и сортировки. Hash оптимизирован для равенства, но обычно не даёт преимуществ над B-tree. GIN эффективен для составных значений, массивов, JSONB и полнотекстового поиска. GiST поддерживает расширяемые стратегии, геометрию, диапазоны и nearest-neighbor поиск." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000352"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда partial index лучше полного и какой у него главный подводный камень?». Поэтому он не отвечает на текущую формулировку.", "Partial index полезен для небольшого часто запрашиваемого подмножества, например active rows, уменьшая размер и write cost. Planner использует его только если может доказать, что WHERE запроса подразумевает predicate индекса. Параметризованное или иначе сформулированное условие может помешать доказательству." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000354"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему Read Committed может видеть разные данные в двух SELECT одной транзакции?». Поэтому он не отвечает на текущую формулировку.", "Каждый statement получает новый snapshot на начало statement, поэтому committed изменения между запросами становятся видимыми. Это нормальная гарантия уровня, а не ошибка MVCC. Если бизнес-инвариант требует стабильного snapshot, используют Repeatable Read/Serializable или формулируют операцию одним atomic statement." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000361"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как читать EXPLAIN ANALYZE и какие признаки указывают на проблему?». Поэтому он не отвечает на текущую формулировку.", "Сравнивают estimated и actual rows, время узлов, число loops, способ доступа и операции сортировки/хеширования. Большие расхождения строк указывают на устаревшую статистику или коррелированные данные. Seq Scan не всегда плох: он разумен для маленькой таблицы или выборки большой доли строк." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000362"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Для чего нужны expression indexes и почему функция должна быть подходящей?». Поэтому он не отвечает на текущую формулировку.", "Они индексируют результат выражения, например lower(email), чтобы запрос с тем же выражением использовал B-tree. Выражение должно быть immutable относительно строки; иначе индекс перестанет соответствовать данным. Цена вычисляется при insert/update, а синтаксис запроса должен совпадать распознаваемым образом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000363"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как advisory locks использовать безопасно?». Поэтому он не отвечает на текущую формулировку.", "Они дают application-defined ключ и не привязаны автоматически к строке, поэтому все участники обязаны следовать одному протоколу. Transaction-level locks освобождаются при завершении транзакции и обычно безопаснее session-level. Нужно избегать коллизий ключей, держать lock коротко и не считать его заменой database constraints." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000372"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие уровни изоляции транзакций поддерживает PostgreSQL и когда нужен Serializable?». Поэтому он не отвечает на текущую формулировку.", "PostgreSQL предоставляет Read Committed, Repeatable Read и Serializable; Read Uncommitted ведёт себя как Read Committed. Serializable нужен, когда результат параллельных транзакций должен быть эквивалентен последовательному выполнению. Он может завершить транзакцию serialization failure, поэтому приложение обязано поддерживать retry." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000373"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как extended statistics исправляют ошибки оценки planner?». Поэтому он не отвечает на текущую формулировку.", "Обычная статистика считает колонки в основном независимо, поэтому коррелированные predicates дают ошибочную cardinality. CREATE STATISTICS может собирать dependencies, ndistinct или MCV для группы колонок. Это улучшает выбор join/order, но не заменяет актуальный ANALYZE и не собирает статистику между разными таблицами." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000374"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как UPSERT с ON CONFLICT помогает конкурентности и где остаются гонки?». Поэтому он не отвечает на текущую формулировку.", "INSERT ... ON CONFLICT атомарно использует unique constraint для insert/update и устраняет check-then-act race. Но update expression всё равно должен сохранять бизнес-инвариант, а несколько связанных строк требуют транзакции или другого constraint. Неверный conflict target и side effects вне БД остаются проблемой." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000381"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему индекс может не использоваться планировщиком PostgreSQL?». Поэтому он не отвечает на текущую формулировку.", "Последовательное чтение может быть дешевле для маленькой таблицы или низкой селективности. Причинами также бывают несовместимое выражение или преобразование типа, устаревшая статистика, ведущий wildcard, неподходящий порядок составного индекса и функции без соответствующего expression index." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000383"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем nested loop, hash join и merge join отличаются по условиям эффективности?». Поэтому он не отвечает на текущую формулировку.", "Nested loop хорош для малого outer input и индексного поиска во inner. Hash join эффективен для больших equality joins при достаточном work_mem; spill замедляет его. Merge join использует отсортированные входы и полезен для больших упорядочиваемых наборов или range-подобных условий. Решение зависит от оценок cardinality." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000384"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать partition key для большой таблицы?». Поэтому он не отвечает на текущую формулировку.", "Ключ должен поддерживать pruning основных запросов, lifecycle данных и равномерное распределение. Временной range удобен для retention, hash — для распределения, list — для ограниченных доменов. Слишком много partition увеличивает planning/metadata overhead, а unique constraint обычно должен включать partition key." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000391"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему длинная транзакция мешает VACUUM и чем это проявляется?». Поэтому он не отвечает на текущую формулировку.", "Долгая transaction snapshot удерживает xmin, поэтому версии строк, потенциально видимые ей, нельзя удалить. Dead tuples накапливаются, таблицы и индексы раздуваются, планы и I/O ухудшаются, а wraparound risk растёт. Ищут age транзакций и idle in transaction sessions, ограничивают timeout и сокращают бизнес-операции внутри транзакции." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000392"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как work_mem влияет на sort/hash и почему нельзя просто поставить большое значение глобально?». Поэтому он не отвечает на текущую формулировку.", "work_mem применяется на каждый sort/hash node и потенциально на каждого parallel worker, поэтому один запрос может потребить его многократно, а множество сессий — исчерпать RAM. Малое значение вызывает temp spill. Настраивают глобально умеренно, а для известных аналитических операций — локально в транзакции после измерения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000394"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему partitioning не является универсальным способом ускорить запросы?». Поэтому он не отвечает на текущую формулировку.", "Она помогает, когда pruning исключает большую часть данных или облегчает maintenance, но запросы по другому ключу могут читать все partitions. Индексы всё равно нужны, joins и planning усложняются, skew создаёт hot partition. Сначала подтверждают проблему размера, retention или contention." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000401"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Чем VACUUM, VACUUM FULL и autovacuum отличаются по назначению?». Поэтому он не отвечает на текущую формулировку.", "Обычный VACUUM помечает место reusable и обновляет visibility map без возврата файла ОС; он допускает параллельную работу. VACUUM FULL переписывает таблицу, возвращает место, но берёт сильную блокировку. Autovacuum выполняет регулярную очистку/analyze и anti-wraparound; его чаще настраивают, а не отключают." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000402"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что означает Rows Removed by Filter в EXPLAIN ANALYZE?». Поэтому он не отвечает на текущую формулировку.", "Это число строк, прочитанных узлом, но отброшенных его filter; большое значение может указывать на плохой access path или отсутствующий подходящий индекс. Однако для маленькой таблицы sequential scan может быть дешевле. Смотрят actual loops, buffers, время и отношение estimated к actual rows в контексте всего плана." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("51000000-0000-0000-0000-000000000403"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как безопасно удалять старые данные из очень большой временной таблицы?». Поэтому он не отвечает на текущую формулировку.", "Если таблица partitioned по времени, detach/drop старой partition почти мгновенно освобождает логический объём и избегает миллионов row deletes/WAL. Без partitioning удаляют небольшими batches с паузами и vacuum, контролируя replicas и locks. Большая одиночная DELETE создаёт bloat и длительную транзакцию." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000012"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда eventual consistency является корректной бизнес-семантикой, а не техническим оправданием?». Поэтому он не отвечает на текущую формулировку.", "Когда бизнес допускает промежуточное состояние и имеет ясное окно, статус и способ разрешения конфликта: например заказ принят, резерв ожидается. Пользователь должен видеть pending/failed, процесс — быть идемпотентным и наблюдаемым. Если нарушение правила даже на мгновение недопустимо, данные принадлежат одной strong-consistency границе." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000013"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда modular monolith является лучшей стартовой архитектурой?». Поэтому он не отвечает на текущую формулировку.", "Когда доменные границы ещё уточняются, команда невелика и независимый deployment не окупает distributed cost. Модули получают private data/schema ownership, явные contracts и dependency tests, оставаясь в одном процессе и deployment. Это не слоистый монолит: границы должны быть реальными, чтобы при необходимости выделиться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000014"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие компромиссы у cache-aside?». Поэтому он не отвечает на текущую формулировку.", "Приложение сначала читает кэш, при miss — источник и заполняет кэш; это просто и устойчиво к падению кэша. Между write и invalidation возможны stale reads, stampede и race с поздним заполнением. TTL, versioned keys, single-flight и событие invalidation уменьшают риск, но consistency остаётся явной." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000021"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как Saga координирует распределённый бизнес-процесс и в чём отличие orchestration от choreography?». Поэтому он не отвечает на текущую формулировку.", "Saga разбивает процесс на локальные транзакции и компенсирующие действия. Orchestrator явно хранит состояние и посылает команды, упрощая наблюдаемость сложного workflow; choreography связывает сервисы событиями и лучше для простого процесса, но легко создаёт скрытый граф. Компенсация — новая бизнес-операция, а не магический rollback." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000023"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие сигналы действительно оправдывают выделение микросервиса?». Поэтому он не отвечает на текущую формулировку.", "Независимый ownership и cadence, отдельное масштабирование, security/isolation, иной availability requirement или стабильная bounded-context граница. Размер кода сам по себе слабый аргумент. До выделения оценивают distributed transactions, latency, observability, on-call и стоимость versioned contracts." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000024"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как бороться с cache stampede?». Поэтому он не отвечает на текущую формулировку.", "Используют per-key request coalescing/single-flight, jittered TTL, background refresh и stale-while-revalidate. Для критичных ключей можно краткий distributed lock, но нужен timeout и fallback. Предварительный прогрев помогает известным hot keys; бесконечный retry к источнику при miss усугубляет отказ." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000031"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему distributed transaction редко является лучшим способом связать сервисы?». Поэтому он не отвечает на текущую формулировку.", "Она связывает availability и latency участников, усложняет recovery и часто не поддерживается внешними системами. Outbox, idempotency и saga дают локальную атомарность и явное промежуточное состояние. Distributed transaction допустима в ограниченной инфраструктуре с измеренной ценой, но не должна скрывать отсутствие бизнес-политики отказа." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000032"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое connascence и как она помогает оценивать coupling?». Поэтому он не отвечает на текущую формулировку.", "Компоненты связаны не только ссылками, но и общим значением, порядком, алгоритмом, временем или идентичностью. Чем сильнее и дальше connascence, тем дороже изменение. Сильные формы стараются держать локально, а через удалённые границы оставлять явные стабильные контракты и минимальные временные предположения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000034"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда event sourcing оправдан?». Поэтому он не отвечает на текущую формулировку.", "Когда история изменений является бизнес-ценностью, нужны temporal queries/audit, сложные процессы или восстановление новых projections. Цена — эволюция событий, replay, storage, eventual consistency и иной способ исправления ошибок. Если нужен только audit log, обычная модель плюс неизменяемый журнал часто проще." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000041"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как определить, что два модуля имеют неправильное направление зависимости?». Поэтому он не отвечает на текущую формулировку.", "Если изменение внутренней модели одного постоянно заставляет менять другой, общий контракт содержит чужие сущности или low-level слой диктует use case, зависимость направлена не по policy. Стабильные бизнес-правила должны зависеть от абстракций, а детали реализовывать их. Метрики coupling помогают, но решающим остаётся ownership причин изменения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000042"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как спроектировать API для эволюции без бесконечного версионирования?». Поэтому он не отвечает на текущую формулировку.", "Контракт делают ориентированным на capability, добавляют optional поля, сохраняют семантику и применяют tolerant reader. Breaking change получает новую версию с периодом coexistence и telemetry использования старой. Внутреннюю entity не сериализуют напрямую, иначе каждое изменение модели становится внешним." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000043"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как изменять схему событий в event-sourced системе?». Поэтому он не отвечает на текущую формулировку.", "Старые события остаются фактом и обычно не переписываются. Read path применяет upcasters или handlers нескольких версий, а новые writers выпускают новую совместимую версию. Миграция snapshot/projection отделена; каждый replay тестируют на полном историческом наборе и детерминированных dependencies." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000052"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что Clean Architecture гарантирует, а чего не гарантирует?». Поэтому он не отвечает на текущую формулировку.", "Она направляет зависимости к policy, изолирует use cases от UI, БД и frameworks и облегчает тестирование заменяемых деталей. Она не создаёт правильную доменную модель, производительность или распределённую надёжность автоматически. Чрезмерное число pass-through слоёв и generic abstractions может увеличить ceremony без реальной независимости." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000053"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему idempotency key должен быть связан с бизнес-операцией, а не случайной HTTP-попыткой?». Поэтому он не отвечает на текущую формулировку.", "Все retries одного намерения должны нести один ключ, иначе сервер не отличит повтор от новой операции. Сервер атомарно сохраняет ключ, fingerprint запроса и результат в ограниченном scope пользователя/операции. Повтор с тем же ключом и другим payload отклоняется, а retention соответствует окну повторов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000054"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать snapshot frequency в event sourcing?». Поэтому он не отвечает на текущую формулировку.", "Snapshot — производительная оптимизация, не источник истины. Его делают после измеренного числа событий или стоимости fold, версионируют вместе с моделью и умеют отбросить/rebuild. Слишком частые snapshots увеличивают writes, слишком редкие — recovery latency; важнее сохранить корректность replay." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000061"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда repository должен возвращать агрегат, а когда специализированный DTO?». Поэтому он не отвечает на текущую формулировку.", "Write-side repository восстанавливает aggregate root для выполнения поведения и скрывает persistence. Read use case не обязан материализовать агрегат: проекция DTO может обращаться к оптимизированному query service/read model. Смешивание IQueryable в доменный контракт выдаёт детали хранения и позволяет обходить границы агрегата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000063"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как circuit breaker отличается от retry и timeout?». Поэтому он не отвечает на текущую формулировку.", "Timeout ограничивает одну попытку, retry повторяет вероятно транзиентный сбой, circuit breaker временно прекращает вызовы к явно нездоровой зависимости. Вместе они защищают ресурсы, но неверные настройки умножают нагрузку. Нужны общий deadline, jitter, ограничение конкуренции и ясная fallback-семантика." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000064"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое anti-corruption layer?». Поэтому он не отвечает на текущую формулировку.", "ACL переводит модель внешней или legacy-системы в язык собственного bounded context и не даёт чужим понятиям проникнуть внутрь. Это adapters, translators и policy, а не только HTTP client wrapper. Цена дополнительного кода окупается, когда внешняя модель нестабильна, неоднозначна или имеет другой жизненный цикл." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000071"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как применять domain events внутри одного процесса, не превращая их в ненадёжную интеграцию?». Поэтому он не отвечает на текущую формулировку.", "Domain event фиксирует факт внутри модели; handlers могут обновить локальное состояние до commit или подготовить outbox. Порядок, повторный вызов и ошибка должны иметь определённую семантику. Для внешних подписчиков событие преобразуют в integration event и публикуют после атомарной записи, а не отправляют из агрегата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000072"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое bulkhead и где его размещать?». Поэтому он не отвечает на текущую формулировку.", "Bulkhead разделяет ограниченные ресурсы, чтобы отказ одного workload/tenant/dependency не исчерпал все threads, connections или queue capacity. Это могут быть отдельные pools, semaphores, queues или deployments. Границы выбирают по failure domain и SLO; слишком мелкое деление снижает utilization." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000074"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как context map помогает проектировать взаимодействие команд?». Поэтому он не отвечает на текущую формулировку.", "Он фиксирует bounded contexts и отношения upstream/downstream: partnership, customer-supplier, conformist, ACL, published language и другие. Это делает зависимости и власть над контрактом явными. Карта должна отражать организационную реальность ownership, иначе желаемая схема быстро расходится с кодом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000081"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать consistency boundary для команды, меняющей несколько агрегатов?». Поэтому он не отвечает на текущую формулировку.", "Сначала проверяют, действительно ли правило должно быть атомарным. Если да, возможно граница агрегата неверна или нужна database constraint/одна транзакция application service. Если допускается задержка, команда меняет один агрегат и запускает process manager; конфликты и компенсации становятся частью модели." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000082"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как backpressure должна проходить через многоуровневую систему?». Поэтому он не отвечает на текущую формулировку.", "Когда downstream насыщен, upstream должен замедлиться, получить явный reject/429 или сбросить нагрузку по политике, а не бесконечно накапливать memory и queues. Bounded buffers, concurrency limits и deadlines задают пределы на каждом участке. Retry учитывает сигнал и не превращает перегрузку в storm." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000083"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему shared database между сервисами опасна?». Поэтому он не отвечает на текущую формулировку.", "Сервисы обходят API друг друга, связываются схемой и транзакциями, миграции требуют координации, а ownership данных размывается. Даже read-only доступ создаёт скрытый контракт. Переход возможен через выделение владельца таблиц, published views/events и постепенное прекращение прямых writes." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000092"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «В чём практическая ценность ubiquitous language?». Поэтому он не отвечает на текущую формулировку.", "Единый язык связывает разговор с экспертом, модель, команды, события и код, уменьшая перевод и неоднозначность. Один термин не должен означать разные вещи внутри context, а разные понятия не маскируются общим DTO. Изменение языка — сигнал уточнить модель, а не просто переименовать классы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000093"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как сформулировать SLI, SLO и error budget для API?». Поэтому он не отвечает на текущую формулировку.", "SLI — измеряемая доля хороших событий, например запросы быстрее 300 мс без 5xx; SLO — целевая доля за окно. Error budget — допустимый остаток неуспеха, который связывает reliability с темпом изменений. Метрика должна отражать пользовательский outcome и исключать только заранее определённые случаи." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000094"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как strangler pattern снижает риск замены legacy-системы?». Поэтому он не отвечает на текущую формулировку.", "Трафик и capabilities переносят небольшими вертикальными срезами через facade/router, сохраняя работающий legacy для остального. Нужны ownership данных, синхронизация и критерий выключения старого пути. Простое дублирование функций без удаления legacy создаёт две постоянные системы и больший риск." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000101"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как распознать anemic domain model и всегда ли она плоха?». Поэтому он не отвечает на текущую формулировку.", "Если entities — набор setters, а правила размазаны по services, инварианты легко обходятся и модель анемична. Rich model полезна для сложного поведения и жизненного цикла. В простом CRUD bounded context сложность домена мала, и попытка искусственно добавить методы и aggregates только увеличит ceremony." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000103"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему средняя latency недостаточна для архитектурных решений?». Поэтому он не отвечает на текущую формулировку.", "Среднее скрывает tail, который определяет опыт многих пользователей и усиливается при fan-out: максимум нескольких downstream растёт. Смотрят p50/p95/p99, распределение, saturation и ошибки по endpoint/tenant. Оптимизация tail часто требует limits, кэша, устранения очередей и медленных зависимостей." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000104"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как architecture decision record должен помогать, а не превращаться в бюрократию?». Поэтому он не отвечает на текущую формулировку.", "ADR кратко фиксирует контекст, решение, альтернативы, последствия и статус на момент выбора. Он объясняет почему, а не пересказывает реализацию, и обновляется новым ADR при пересмотре. Записывают значимые труднообратимые решения; документ хранится рядом с кодом и связан с измеримыми ограничениями." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000111"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда modular monolith является лучшей стартовой архитектурой?». Поэтому он не отвечает на текущую формулировку.", "Когда доменные границы ещё уточняются, команда невелика и независимый deployment не окупает distributed cost. Модули получают private data/schema ownership, явные contracts и dependency tests, оставаясь в одном процессе и deployment. Это не слоистый монолит: границы должны быть реальными, чтобы при необходимости выделиться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000112"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как распределённая трассировка помогает и где может ввести в заблуждение?». Поэтому он не отвечает на текущую формулировку.", "Trace связывает causality через сервисы и очереди, показывает critical path и fan-out. Sampling может пропустить редкие ошибки, clock/async boundaries и неверная propagation искажают картину, а наличие span не доказывает причину. Traces дополняют metrics, logs и профили, а не заменяют их." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000114"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как оценивать build versus buy для критичного компонента?». Поэтому он не отвечает на текущую формулировку.", "Сравнивают не только лицензию, но и time-to-value, операционную зрелость, integration cost, lock-in, compliance, roadmap и стоимость владения/миграции. Строить стоит для дифференцирующей capability или уникальных требований; commodity чаще покупают. Решение включает exit strategy и proof of concept главного риска." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000121"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие сигналы действительно оправдывают выделение микросервиса?». Поэтому он не отвечает на текущую формулировку.", "Независимый ownership и cadence, отдельное масштабирование, security/isolation, иной availability requirement или стабильная bounded-context граница. Размер кода сам по себе слабый аргумент. До выделения оценивают distributed transactions, latency, observability, on-call и стоимость versioned contracts." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000122"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать multi-tenant систему с разным уровнем изоляции?». Поэтому он не отвечает на текущую формулировку.", "Модель выбирают по риску и масштабу: shared tables с tenant key, schema-per-tenant или database-per-tenant. Нужны защита от cross-tenant query, квоты, encryption/audit и план noisy neighbor. Часто применяют tiers: общая инфраструктура для большинства и выделенная для регулируемых клиентов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000123"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие границы определяют агрегат в DDD?». Поэтому он не отвечает на текущую формулировку.", "Агрегат — граница строгой согласованности и транзакции. Внешний код обращается только к Aggregate Root, который защищает инварианты. Другие агрегаты связываются по идентификатору, а не через большой объектный граф; eventual consistency между агрегатами реализуют доменными событиями." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000132"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое connascence и как она помогает оценивать coupling?». Поэтому он не отвечает на текущую формулировку.", "Компоненты связаны не только ссылками, но и общим значением, порядком, алгоритмом, временем или идентичностью. Чем сильнее и дальше connascence, тем дороже изменение. Сильные формы стараются держать локально, а через удалённые границы оставлять явные стабильные контракты и минимальные временные предположения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000133"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие компромиссы у cache-aside?». Поэтому он не отвечает на текущую формулировку.", "Приложение сначала читает кэш, при miss — источник и заполняет кэш; это просто и устойчиво к падению кэша. Между write и invalidation возможны stale reads, stampede и race с поздним заполнением. TTL, versioned keys, single-flight и событие invalidation уменьшают риск, но consistency остаётся явной." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000134"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда CQRS полезен, а когда становится лишней сложностью?». Поэтому он не отвечает на текущую формулировку.", "CQRS полезен, когда модели чтения и изменения заметно различаются, нужны независимое масштабирование, сложные бизнес-команды или разные требования к консистентности. Для простого CRUD разделение добавляет типы, обработчики и инфраструктуру без достаточной выгоды. CQRS не требует автоматически отдельных баз или event sourcing." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000141"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как спроектировать API для эволюции без бесконечного версионирования?». Поэтому он не отвечает на текущую формулировку.", "Контракт делают ориентированным на capability, добавляют optional поля, сохраняют семантику и применяют tolerant reader. Breaking change получает новую версию с периодом coexistence и telemetry использования старой. Внутреннюю entity не сериализуют напрямую, иначе каждое изменение модели становится внешним." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000143"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как бороться с cache stampede?». Поэтому он не отвечает на текущую формулировку.", "Используют per-key request coalescing/single-flight, jittered TTL, background refresh и stale-while-revalidate. Для критичных ключей можно краткий distributed lock, но нужен timeout и fallback. Предварительный прогрев помогает известным hot keys; бесконечный retry к источнику при miss усугубляет отказ." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000144"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать между монолитом, модульным монолитом и микросервисами?». Поэтому он не отвечает на текущую формулировку.", "Выбор зависит от организационных границ, независимого масштабирования, скорости изменений и операционной зрелости. Модульный монолит часто является лучшей стартовой точкой: сохраняет простые транзакции и деплой, но дисциплинирует границы. Микросервисы оправданы, когда независимость команд и частей системы окупает распределённую сложность." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000151"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему idempotency key должен быть связан с бизнес-операцией, а не случайной HTTP-попыткой?». Поэтому он не отвечает на текущую формулировку.", "Все retries одного намерения должны нести один ключ, иначе сервер не отличит повтор от новой операции. Сервер атомарно сохраняет ключ, fingerprint запроса и результат в ограниченном scope пользователя/операции. Повтор с тем же ключом и другим payload отклоняется, а retention соответствует окну повторов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000152"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда event sourcing оправдан?». Поэтому он не отвечает на текущую формулировку.", "Когда история изменений является бизнес-ценностью, нужны temporal queries/audit, сложные процессы или восстановление новых projections. Цена — эволюция событий, replay, storage, eventual consistency и иной способ исправления ошибок. Если нужен только audit log, обычная модель плюс неизменяемый журнал часто проще." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000154"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое transactional outbox и какую проблему он решает?». Поэтому он не отвечает на текущую формулировку.", "Изменение бизнес-данных и запись сообщения outbox выполняются в одной локальной транзакции. Отдельный publisher читает outbox и доставляет сообщения брокеру с повторами. Это устраняет dual-write между БД и брокером, но потребители всё равно должны быть идемпотентными из-за возможных дубликатов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000161"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как circuit breaker отличается от retry и timeout?». Поэтому он не отвечает на текущую формулировку.", "Timeout ограничивает одну попытку, retry повторяет вероятно транзиентный сбой, circuit breaker временно прекращает вызовы к явно нездоровой зависимости. Вместе они защищают ресурсы, но неверные настройки умножают нагрузку. Нужны общий deadline, jitter, ограничение конкуренции и ясная fallback-семантика." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000162"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как изменять схему событий в event-sourced системе?». Поэтому он не отвечает на текущую формулировку.", "Старые события остаются фактом и обычно не переписываются. Read path применяет upcasters или handlers нескольких версий, а новые writers выпускают новую совместимую версию. Миграция snapshot/projection отделена; каждый replay тестируют на полном историческом наборе и детерминированных dependencies." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000163"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать идемпотентный API или обработчик команды?». Поэтому он не отвечает на текущую формулировку.", "Операция должна давать один бизнес-результат при повторном запросе. Используют idempotency key, уникальное ограничение и атомарную запись результата, сохраняя ответ для повторного возврата. Важно определить срок хранения ключей и отличать повтор того же запроса от конфликта с другим содержимым." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000172"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое bulkhead и где его размещать?». Поэтому он не отвечает на текущую формулировку.", "Bulkhead разделяет ограниченные ресурсы, чтобы отказ одного workload/tenant/dependency не исчерпал все threads, connections или queue capacity. Это могут быть отдельные pools, semaphores, queues или deployments. Границы выбирают по failure domain и SLO; слишком мелкое деление снижает utilization." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000173"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать snapshot frequency в event sourcing?». Поэтому он не отвечает на текущую формулировку.", "Snapshot — производительная оптимизация, не источник истины. Его делают после измеренного числа событий или стоимости fold, версионируют вместе с моделью и умеют отбросить/rebuild. Слишком частые snapshots увеличивают writes, слишком редкие — recovery latency; важнее сохранить корректность replay." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000174"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как отличить bounded context от микросервиса?». Поэтому он не отвечает на текущую формулировку.", "Bounded context — граница модели и языка, где термины имеют однозначный смысл; это логическая граница DDD. Микросервис — deployment и operational boundary. Один сервис может временно содержать несколько контекстов, а один контекст иногда разворачивается несколькими компонентами; связь выбирают по ownership, coupling и независимости изменений." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000181"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как backpressure должна проходить через многоуровневую систему?». Поэтому он не отвечает на текущую формулировку.", "Когда downstream насыщен, upstream должен замедлиться, получить явный reject/429 или сбросить нагрузку по политике, а не бесконечно накапливать memory и queues. Bounded buffers, concurrency limits и deadlines задают пределы на каждом участке. Retry учитывает сигнал и не превращает перегрузку в storm." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000183"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое anti-corruption layer?». Поэтому он не отвечает на текущую формулировку.", "ACL переводит модель внешней или legacy-системы в язык собственного bounded context и не даёт чужим понятиям проникнуть внутрь. Это adapters, translators и policy, а не только HTTP client wrapper. Цена дополнительного кода окупается, когда внешняя модель нестабильна, неоднозначна или имеет другой жизненный цикл." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000184"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое invariant и почему именно он определяет транзакционную границу агрегата?». Поэтому он не отвечает на текущую формулировку.", "Invariant — правило, которое должно быть истинно после каждой успешной команды. Aggregate root сериализует изменения внутри своей границы и проверяет правила в одной транзакции. Если граница включает всё связанное, возникает огромный lock/graph; между агрегатами применяют ссылки по id и eventual consistency с компенсацией." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000191"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как сформулировать SLI, SLO и error budget для API?». Поэтому он не отвечает на текущую формулировку.", "SLI — измеряемая доля хороших событий, например запросы быстрее 300 мс без 5xx; SLO — целевая доля за окно. Error budget — допустимый остаток неуспеха, который связывает reliability с темпом изменений. Метрика должна отражать пользовательский outcome и исключать только заранее определённые случаи." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000192"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как context map помогает проектировать взаимодействие команд?». Поэтому он не отвечает на текущую формулировку.", "Он фиксирует bounded contexts и отношения upstream/downstream: partnership, customer-supplier, conformist, ACL, published language и другие. Это делает зависимости и власть над контрактом явными. Карта должна отражать организационную реальность ownership, иначе желаемая схема быстро расходится с кодом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000194"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда eventual consistency является корректной бизнес-семантикой, а не техническим оправданием?». Поэтому он не отвечает на текущую формулировку.", "Когда бизнес допускает промежуточное состояние и имеет ясное окно, статус и способ разрешения конфликта: например заказ принят, резерв ожидается. Пользователь должен видеть pending/failed, процесс — быть идемпотентным и наблюдаемым. Если нарушение правила даже на мгновение недопустимо, данные принадлежат одной strong-consistency границе." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000201"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему средняя latency недостаточна для архитектурных решений?». Поэтому он не отвечает на текущую формулировку.", "Среднее скрывает tail, который определяет опыт многих пользователей и усиливается при fan-out: максимум нескольких downstream растёт. Смотрят p50/p95/p99, распределение, saturation и ошибки по endpoint/tenant. Оптимизация tail часто требует limits, кэша, устранения очередей и медленных зависимостей." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000202"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему shared database между сервисами опасна?». Поэтому он не отвечает на текущую формулировку.", "Сервисы обходят API друг друга, связываются схемой и транзакциями, миграции требуют координации, а ownership данных размывается. Даже read-only доступ создаёт скрытый контракт. Переход возможен через выделение владельца таблиц, published views/events и постепенное прекращение прямых writes." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000203"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как Saga координирует распределённый бизнес-процесс и в чём отличие orchestration от choreography?». Поэтому он не отвечает на текущую формулировку.", "Saga разбивает процесс на локальные транзакции и компенсирующие действия. Orchestrator явно хранит состояние и посылает команды, упрощая наблюдаемость сложного workflow; choreography связывает сервисы событиями и лучше для простого процесса, но легко создаёт скрытый граф. Компенсация — новая бизнес-операция, а не магический rollback." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000212"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как распределённая трассировка помогает и где может ввести в заблуждение?». Поэтому он не отвечает на текущую формулировку.", "Trace связывает causality через сервисы и очереди, показывает critical path и fan-out. Sampling может пропустить редкие ошибки, clock/async boundaries и неверная propagation искажают картину, а наличие span не доказывает причину. Traces дополняют metrics, logs и профили, а не заменяют их." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000213"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как strangler pattern снижает риск замены legacy-системы?». Поэтому он не отвечает на текущую формулировку.", "Трафик и capabilities переносят небольшими вертикальными срезами через facade/router, сохраняя работающий legacy для остального. Нужны ownership данных, синхронизация и критерий выключения старого пути. Простое дублирование функций без удаления legacy создаёт две постоянные системы и больший риск." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000214"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему distributed transaction редко является лучшим способом связать сервисы?». Поэтому он не отвечает на текущую формулировку.", "Она связывает availability и latency участников, усложняет recovery и часто не поддерживается внешними системами. Outbox, idempotency и saga дают локальную атомарность и явное промежуточное состояние. Distributed transaction допустима в ограниченной инфраструктуре с измеренной ценой, но не должна скрывать отсутствие бизнес-политики отказа." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000221"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать multi-tenant систему с разным уровнем изоляции?». Поэтому он не отвечает на текущую формулировку.", "Модель выбирают по риску и масштабу: shared tables с tenant key, schema-per-tenant или database-per-tenant. Нужны защита от cross-tenant query, квоты, encryption/audit и план noisy neighbor. Часто применяют tiers: общая инфраструктура для большинства и выделенная для регулируемых клиентов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000223"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как architecture decision record должен помогать, а не превращаться в бюрократию?». Поэтому он не отвечает на текущую формулировку.", "ADR кратко фиксирует контекст, решение, альтернативы, последствия и статус на момент выбора. Он объясняет почему, а не пересказывает реализацию, и обновляется новым ADR при пересмотре. Записывают значимые труднообратимые решения; документ хранится рядом с кодом и связан с измеримыми ограничениями." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000224"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как определить, что два модуля имеют неправильное направление зависимости?». Поэтому он не отвечает на текущую формулировку.", "Если изменение внутренней модели одного постоянно заставляет менять другой, общий контракт содержит чужие сущности или low-level слой диктует use case, зависимость направлена не по policy. Стабильные бизнес-правила должны зависеть от абстракций, а детали реализовывать их. Метрики coupling помогают, но решающим остаётся ownership причин изменения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000231"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие компромиссы у cache-aside?». Поэтому он не отвечает на текущую формулировку.", "Приложение сначала читает кэш, при miss — источник и заполняет кэш; это просто и устойчиво к падению кэша. Между write и invalidation возможны stale reads, stampede и race с поздним заполнением. TTL, versioned keys, single-flight и событие invalidation уменьшают риск, но consistency остаётся явной." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000232"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как оценивать build versus buy для критичного компонента?». Поэтому он не отвечает на текущую формулировку.", "Сравнивают не только лицензию, но и time-to-value, операционную зрелость, integration cost, lock-in, compliance, roadmap и стоимость владения/миграции. Строить стоит для дифференцирующей capability или уникальных требований; commodity чаще покупают. Решение включает exit strategy и proof of concept главного риска." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000234"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что Clean Architecture гарантирует, а чего не гарантирует?». Поэтому он не отвечает на текущую формулировку.", "Она направляет зависимости к policy, изолирует use cases от UI, БД и frameworks и облегчает тестирование заменяемых деталей. Она не создаёт правильную доменную модель, производительность или распределённую надёжность автоматически. Чрезмерное число pass-through слоёв и generic abstractions может увеличить ceremony без реальной независимости." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000241"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как бороться с cache stampede?». Поэтому он не отвечает на текущую формулировку.", "Используют per-key request coalescing/single-flight, jittered TTL, background refresh и stale-while-revalidate. Для критичных ключей можно краткий distributed lock, но нужен timeout и fallback. Предварительный прогрев помогает известным hot keys; бесконечный retry к источнику при miss усугубляет отказ." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000242"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие границы определяют агрегат в DDD?». Поэтому он не отвечает на текущую формулировку.", "Агрегат — граница строгой согласованности и транзакции. Внешний код обращается только к Aggregate Root, который защищает инварианты. Другие агрегаты связываются по идентификатору, а не через большой объектный граф; eventual consistency между агрегатами реализуют доменными событиями." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000243"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда repository должен возвращать агрегат, а когда специализированный DTO?». Поэтому он не отвечает на текущую формулировку.", "Write-side repository восстанавливает aggregate root для выполнения поведения и скрывает persistence. Read use case не обязан материализовать агрегат: проекция DTO может обращаться к оптимизированному query service/read model. Смешивание IQueryable в доменный контракт выдаёт детали хранения и позволяет обходить границы агрегата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000252"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда event sourcing оправдан?». Поэтому он не отвечает на текущую формулировку.", "Когда история изменений является бизнес-ценностью, нужны temporal queries/audit, сложные процессы или восстановление новых projections. Цена — эволюция событий, replay, storage, eventual consistency и иной способ исправления ошибок. Если нужен только audit log, обычная модель плюс неизменяемый журнал часто проще." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000253"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда CQRS полезен, а когда становится лишней сложностью?». Поэтому он не отвечает на текущую формулировку.", "CQRS полезен, когда модели чтения и изменения заметно различаются, нужны независимое масштабирование, сложные бизнес-команды или разные требования к консистентности. Для простого CRUD разделение добавляет типы, обработчики и инфраструктуру без достаточной выгоды. CQRS не требует автоматически отдельных баз или event sourcing." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000254"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как применять domain events внутри одного процесса, не превращая их в ненадёжную интеграцию?». Поэтому он не отвечает на текущую формулировку.", "Domain event фиксирует факт внутри модели; handlers могут обновить локальное состояние до commit или подготовить outbox. Порядок, повторный вызов и ошибка должны иметь определённую семантику. Для внешних подписчиков событие преобразуют в integration event и публикуют после атомарной записи, а не отправляют из агрегата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000261"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как изменять схему событий в event-sourced системе?». Поэтому он не отвечает на текущую формулировку.", "Старые события остаются фактом и обычно не переписываются. Read path применяет upcasters или handlers нескольких версий, а новые writers выпускают новую совместимую версию. Миграция snapshot/projection отделена; каждый replay тестируют на полном историческом наборе и детерминированных dependencies." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000263"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать между монолитом, модульным монолитом и микросервисами?». Поэтому он не отвечает на текущую формулировку.", "Выбор зависит от организационных границ, независимого масштабирования, скорости изменений и операционной зрелости. Модульный монолит часто является лучшей стартовой точкой: сохраняет простые транзакции и деплой, но дисциплинирует границы. Микросервисы оправданы, когда независимость команд и частей системы окупает распределённую сложность." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000264"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать consistency boundary для команды, меняющей несколько агрегатов?». Поэтому он не отвечает на текущую формулировку.", "Сначала проверяют, действительно ли правило должно быть атомарным. Если да, возможно граница агрегата неверна или нужна database constraint/одна транзакция application service. Если допускается задержка, команда меняет один агрегат и запускает process manager; конфликты и компенсации становятся частью модели." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000271"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать snapshot frequency в event sourcing?». Поэтому он не отвечает на текущую формулировку.", "Snapshot — производительная оптимизация, не источник истины. Его делают после измеренного числа событий или стоимости fold, версионируют вместе с моделью и умеют отбросить/rebuild. Слишком частые snapshots увеличивают writes, слишком редкие — recovery latency; важнее сохранить корректность replay." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000272"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое transactional outbox и какую проблему он решает?». Поэтому он не отвечает на текущую формулировку.", "Изменение бизнес-данных и запись сообщения outbox выполняются в одной локальной транзакции. Отдельный publisher читает outbox и доставляет сообщения брокеру с повторами. Это устраняет dual-write между БД и брокером, но потребители всё равно должны быть идемпотентными из-за возможных дубликатов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000274"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «В чём практическая ценность ubiquitous language?». Поэтому он не отвечает на текущую формулировку.", "Единый язык связывает разговор с экспертом, модель, команды, события и код, уменьшая перевод и неоднозначность. Один термин не должен означать разные вещи внутри context, а разные понятия не маскируются общим DTO. Изменение языка — сигнал уточнить модель, а не просто переименовать классы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000281"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое anti-corruption layer?». Поэтому он не отвечает на текущую формулировку.", "ACL переводит модель внешней или legacy-системы в язык собственного bounded context и не даёт чужим понятиям проникнуть внутрь. Это adapters, translators и policy, а не только HTTP client wrapper. Цена дополнительного кода окупается, когда внешняя модель нестабильна, неоднозначна или имеет другой жизненный цикл." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000282"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать идемпотентный API или обработчик команды?». Поэтому он не отвечает на текущую формулировку.", "Операция должна давать один бизнес-результат при повторном запросе. Используют idempotency key, уникальное ограничение и атомарную запись результата, сохраняя ответ для повторного возврата. Важно определить срок хранения ключей и отличать повтор того же запроса от конфликта с другим содержимым." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000283"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как распознать anemic domain model и всегда ли она плоха?». Поэтому он не отвечает на текущую формулировку.", "Если entities — набор setters, а правила размазаны по services, инварианты легко обходятся и модель анемична. Rich model полезна для сложного поведения и жизненного цикла. В простом CRUD bounded context сложность домена мала, и попытка искусственно добавить методы и aggregates только увеличит ceremony." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000292"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как context map помогает проектировать взаимодействие команд?». Поэтому он не отвечает на текущую формулировку.", "Он фиксирует bounded contexts и отношения upstream/downstream: partnership, customer-supplier, conformist, ACL, published language и другие. Это делает зависимости и власть над контрактом явными. Карта должна отражать организационную реальность ownership, иначе желаемая схема быстро расходится с кодом." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000293"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как отличить bounded context от микросервиса?». Поэтому он не отвечает на текущую формулировку.", "Bounded context — граница модели и языка, где термины имеют однозначный смысл; это логическая граница DDD. Микросервис — deployment и operational boundary. Один сервис может временно содержать несколько контекстов, а один контекст иногда разворачивается несколькими компонентами; связь выбирают по ownership, coupling и независимости изменений." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000294"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда modular monolith является лучшей стартовой архитектурой?». Поэтому он не отвечает на текущую формулировку.", "Когда доменные границы ещё уточняются, команда невелика и независимый deployment не окупает distributed cost. Модули получают private data/schema ownership, явные contracts и dependency tests, оставаясь в одном процессе и deployment. Это не слоистый монолит: границы должны быть реальными, чтобы при необходимости выделиться." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000301"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему shared database между сервисами опасна?». Поэтому он не отвечает на текущую формулировку.", "Сервисы обходят API друг друга, связываются схемой и транзакциями, миграции требуют координации, а ownership данных размывается. Даже read-only доступ создаёт скрытый контракт. Переход возможен через выделение владельца таблиц, published views/events и постепенное прекращение прямых writes." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000303"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое invariant и почему именно он определяет транзакционную границу агрегата?». Поэтому он не отвечает на текущую формулировку.", "Invariant — правило, которое должно быть истинно после каждой успешной команды. Aggregate root сериализует изменения внутри своей границы и проверяет правила в одной транзакции. Если граница включает всё связанное, возникает огромный lock/graph; между агрегатами применяют ссылки по id и eventual consistency с компенсацией." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000304"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие сигналы действительно оправдывают выделение микросервиса?». Поэтому он не отвечает на текущую формулировку.", "Независимый ownership и cadence, отдельное масштабирование, security/isolation, иной availability requirement или стабильная bounded-context граница. Размер кода сам по себе слабый аргумент. До выделения оценивают distributed transactions, latency, observability, on-call и стоимость versioned contracts." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000311"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как strangler pattern снижает риск замены legacy-системы?». Поэтому он не отвечает на текущую формулировку.", "Трафик и capabilities переносят небольшими вертикальными срезами через facade/router, сохраняя работающий legacy для остального. Нужны ownership данных, синхронизация и критерий выключения старого пути. Простое дублирование функций без удаления legacy создаёт две постоянные системы и больший риск." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000312"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда eventual consistency является корректной бизнес-семантикой, а не техническим оправданием?». Поэтому он не отвечает на текущую формулировку.", "Когда бизнес допускает промежуточное состояние и имеет ясное окно, статус и способ разрешения конфликта: например заказ принят, резерв ожидается. Пользователь должен видеть pending/failed, процесс — быть идемпотентным и наблюдаемым. Если нарушение правила даже на мгновение недопустимо, данные принадлежат одной strong-consistency границе." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000314"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое connascence и как она помогает оценивать coupling?». Поэтому он не отвечает на текущую формулировку.", "Компоненты связаны не только ссылками, но и общим значением, порядком, алгоритмом, временем или идентичностью. Чем сильнее и дальше connascence, тем дороже изменение. Сильные формы стараются держать локально, а через удалённые границы оставлять явные стабильные контракты и минимальные временные предположения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000321"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как architecture decision record должен помогать, а не превращаться в бюрократию?». Поэтому он не отвечает на текущую формулировку.", "ADR кратко фиксирует контекст, решение, альтернативы, последствия и статус на момент выбора. Он объясняет почему, а не пересказывает реализацию, и обновляется новым ADR при пересмотре. Записывают значимые труднообратимые решения; документ хранится рядом с кодом и связан с измеримыми ограничениями." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000322"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как Saga координирует распределённый бизнес-процесс и в чём отличие orchestration от choreography?». Поэтому он не отвечает на текущую формулировку.", "Saga разбивает процесс на локальные транзакции и компенсирующие действия. Orchestrator явно хранит состояние и посылает команды, упрощая наблюдаемость сложного workflow; choreography связывает сервисы событиями и лучше для простого процесса, но легко создаёт скрытый граф. Компенсация — новая бизнес-операция, а не магический rollback." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000323"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как спроектировать API для эволюции без бесконечного версионирования?». Поэтому он не отвечает на текущую формулировку.", "Контракт делают ориентированным на capability, добавляют optional поля, сохраняют семантику и применяют tolerant reader. Breaking change получает новую версию с периодом coexistence и telemetry использования старой. Внутреннюю entity не сериализуют напрямую, иначе каждое изменение модели становится внешним." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000332"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как оценивать build versus buy для критичного компонента?». Поэтому он не отвечает на текущую формулировку.", "Сравнивают не только лицензию, но и time-to-value, операционную зрелость, integration cost, lock-in, compliance, roadmap и стоимость владения/миграции. Строить стоит для дифференцирующей capability или уникальных требований; commodity чаще покупают. Решение включает exit strategy и proof of concept главного риска." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000333"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему distributed transaction редко является лучшим способом связать сервисы?». Поэтому он не отвечает на текущую формулировку.", "Она связывает availability и latency участников, усложняет recovery и часто не поддерживается внешними системами. Outbox, idempotency и saga дают локальную атомарность и явное промежуточное состояние. Distributed transaction допустима в ограниченной инфраструктуре с измеренной ценой, но не должна скрывать отсутствие бизнес-политики отказа." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000334"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему idempotency key должен быть связан с бизнес-операцией, а не случайной HTTP-попыткой?». Поэтому он не отвечает на текущую формулировку.", "Все retries одного намерения должны нести один ключ, иначе сервер не отличит повтор от новой операции. Сервер атомарно сохраняет ключ, fingerprint запроса и результат в ограниченном scope пользователя/операции. Повтор с тем же ключом и другим payload отклоняется, а retention соответствует окну повторов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000341"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Какие границы определяют агрегат в DDD?». Поэтому он не отвечает на текущую формулировку.", "Агрегат — граница строгой согласованности и транзакции. Внешний код обращается только к Aggregate Root, который защищает инварианты. Другие агрегаты связываются по идентификатору, а не через большой объектный граф; eventual consistency между агрегатами реализуют доменными событиями." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000343"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как определить, что два модуля имеют неправильное направление зависимости?». Поэтому он не отвечает на текущую формулировку.", "Если изменение внутренней модели одного постоянно заставляет менять другой, общий контракт содержит чужие сущности или low-level слой диктует use case, зависимость направлена не по policy. Стабильные бизнес-правила должны зависеть от абстракций, а детали реализовывать их. Метрики coupling помогают, но решающим остаётся ownership причин изменения." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000344"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как circuit breaker отличается от retry и timeout?». Поэтому он не отвечает на текущую формулировку.", "Timeout ограничивает одну попытку, retry повторяет вероятно транзиентный сбой, circuit breaker временно прекращает вызовы к явно нездоровой зависимости. Вместе они защищают ресурсы, но неверные настройки умножают нагрузку. Нужны общий deadline, jitter, ограничение конкуренции и ясная fallback-семантика." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000351"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда CQRS полезен, а когда становится лишней сложностью?». Поэтому он не отвечает на текущую формулировку.", "CQRS полезен, когда модели чтения и изменения заметно различаются, нужны независимое масштабирование, сложные бизнес-команды или разные требования к консистентности. Для простого CRUD разделение добавляет типы, обработчики и инфраструктуру без достаточной выгоды. CQRS не требует автоматически отдельных баз или event sourcing." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000352"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что Clean Architecture гарантирует, а чего не гарантирует?». Поэтому он не отвечает на текущую формулировку.", "Она направляет зависимости к policy, изолирует use cases от UI, БД и frameworks и облегчает тестирование заменяемых деталей. Она не создаёт правильную доменную модель, производительность или распределённую надёжность автоматически. Чрезмерное число pass-through слоёв и generic abstractions может увеличить ceremony без реальной независимости." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000354"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое bulkhead и где его размещать?». Поэтому он не отвечает на текущую формулировку.", "Bulkhead разделяет ограниченные ресурсы, чтобы отказ одного workload/tenant/dependency не исчерпал все threads, connections или queue capacity. Это могут быть отдельные pools, semaphores, queues или deployments. Границы выбирают по failure domain и SLO; слишком мелкое деление снижает utilization." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000361"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать между монолитом, модульным монолитом и микросервисами?». Поэтому он не отвечает на текущую формулировку.", "Выбор зависит от организационных границ, независимого масштабирования, скорости изменений и операционной зрелости. Модульный монолит часто является лучшей стартовой точкой: сохраняет простые транзакции и деплой, но дисциплинирует границы. Микросервисы оправданы, когда независимость команд и частей системы окупает распределённую сложность." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000362"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Когда repository должен возвращать агрегат, а когда специализированный DTO?». Поэтому он не отвечает на текущую формулировку.", "Write-side repository восстанавливает aggregate root для выполнения поведения и скрывает persistence. Read use case не обязан материализовать агрегат: проекция DTO может обращаться к оптимизированному query service/read model. Смешивание IQueryable в доменный контракт выдаёт детали хранения и позволяет обходить границы агрегата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000363"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как backpressure должна проходить через многоуровневую систему?». Поэтому он не отвечает на текущую формулировку.", "Когда downstream насыщен, upstream должен замедлиться, получить явный reject/429 или сбросить нагрузку по политике, а не бесконечно накапливать memory и queues. Bounded buffers, concurrency limits и deadlines задают пределы на каждом участке. Retry учитывает сигнал и не превращает перегрузку в storm." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000372"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое transactional outbox и какую проблему он решает?». Поэтому он не отвечает на текущую формулировку.", "Изменение бизнес-данных и запись сообщения outbox выполняются в одной локальной транзакции. Отдельный publisher читает outbox и доставляет сообщения брокеру с повторами. Это устраняет dual-write между БД и брокером, но потребители всё равно должны быть идемпотентными из-за возможных дубликатов." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000373"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как применять domain events внутри одного процесса, не превращая их в ненадёжную интеграцию?». Поэтому он не отвечает на текущую формулировку.", "Domain event фиксирует факт внутри модели; handlers могут обновить локальное состояние до commit или подготовить outbox. Порядок, повторный вызов и ошибка должны иметь определённую семантику. Для внешних подписчиков событие преобразуют в integration event и публикуют после атомарной записи, а не отправляют из агрегата." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000374"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как сформулировать SLI, SLO и error budget для API?». Поэтому он не отвечает на текущую формулировку.", "SLI — измеряемая доля хороших событий, например запросы быстрее 300 мс без 5xx; SLO — целевая доля за окно. Error budget — допустимый остаток неуспеха, который связывает reliability с темпом изменений. Метрика должна отражать пользовательский outcome и исключать только заранее определённые случаи." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000381"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать идемпотентный API или обработчик команды?». Поэтому он не отвечает на текущую формулировку.", "Операция должна давать один бизнес-результат при повторном запросе. Используют idempotency key, уникальное ограничение и атомарную запись результата, сохраняя ответ для повторного возврата. Важно определить срок хранения ключей и отличать повтор того же запроса от конфликта с другим содержимым." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000383"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как выбрать consistency boundary для команды, меняющей несколько агрегатов?». Поэтому он не отвечает на текущую формулировку.", "Сначала проверяют, действительно ли правило должно быть атомарным. Если да, возможно граница агрегата неверна или нужна database constraint/одна транзакция application service. Если допускается задержка, команда меняет один агрегат и запускает process manager; конфликты и компенсации становятся частью модели." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000384"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Почему средняя latency недостаточна для архитектурных решений?». Поэтому он не отвечает на текущую формулировку.", "Среднее скрывает tail, который определяет опыт многих пользователей и усиливается при fan-out: максимум нескольких downstream растёт. Смотрят p50/p95/p99, распределение, saturation и ошибки по endpoint/tenant. Оптимизация tail часто требует limits, кэша, устранения очередей и медленных зависимостей." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000391"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как отличить bounded context от микросервиса?». Поэтому он не отвечает на текущую формулировку.", "Bounded context — граница модели и языка, где термины имеют однозначный смысл; это логическая граница DDD. Микросервис — deployment и operational boundary. Один сервис может временно содержать несколько контекстов, а один контекст иногда разворачивается несколькими компонентами; связь выбирают по ownership, coupling и независимости изменений." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000392"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «В чём практическая ценность ubiquitous language?». Поэтому он не отвечает на текущую формулировку.", "Единый язык связывает разговор с экспертом, модель, команды, события и код, уменьшая перевод и неоднозначность. Один термин не должен означать разные вещи внутри context, а разные понятия не маскируются общим DTO. Изменение языка — сигнал уточнить модель, а не просто переименовать классы." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000394"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как распределённая трассировка помогает и где может ввести в заблуждение?». Поэтому он не отвечает на текущую формулировку.", "Trace связывает causality через сервисы и очереди, показывает critical path и fan-out. Sampling может пропустить редкие ошибки, clock/async boundaries и неверная propagation искажают картину, а наличие span не доказывает причину. Traces дополняют metrics, logs и профили, а не заменяют их." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000401"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Что такое invariant и почему именно он определяет транзакционную границу агрегата?». Поэтому он не отвечает на текущую формулировку.", "Invariant — правило, которое должно быть истинно после каждой успешной команды. Aggregate root сериализует изменения внутри своей границы и проверяет правила в одной транзакции. Если граница включает всё связанное, возникает огромный lock/graph; между агрегатами применяют ссылки по id и eventual consistency с компенсацией." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000402"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как распознать anemic domain model и всегда ли она плоха?». Поэтому он не отвечает на текущую формулировку.", "Если entities — набор setters, а правила размазаны по services, инварианты легко обходятся и модель анемична. Rich model полезна для сложного поведения и жизненного цикла. В простом CRUD bounded context сложность домена мала, и попытка искусственно добавить методы и aggregates только увеличит ceremony." });

            migrationBuilder.UpdateData(
                table: "answer_options",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000403"),
                columns: new[] { "explanation", "text" },
                values: new object[] { "Этот вариант технически корректен, но раскрывает другой вопрос: «Как проектировать multi-tenant систему с разным уровнем изоляции?». Поэтому он не отвечает на текущую формулировку.", "Модель выбирают по риску и масштабу: shared tables с tenant key, schema-per-tenant или database-per-tenant. Нужны защита от cross-tenant query, квоты, encryption/audit и план noisy neighbor. Часто применяют tiers: общая инфраструктура для большинства и выделенная для регулируемых клиентов." });
        }
    }
}
