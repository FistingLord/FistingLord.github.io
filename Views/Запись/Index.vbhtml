@ModelType IEnumerable(Of Framework_krasotka.Запись)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.фамилия)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.имя)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.отчество)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.пол)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.услуга)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.дата)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.время)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.фамилия)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.имя)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.отчество)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.пол)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.услуга)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.дата)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.время)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
