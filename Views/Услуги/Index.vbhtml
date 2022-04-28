@ModelType IEnumerable(Of Framework_krasotka.Услуги)
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
            @Html.DisplayNameFor(Function(model) model.название)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.цена)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.продолжительность)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.название)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.цена)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.продолжительность)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
