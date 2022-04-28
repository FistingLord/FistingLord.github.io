@ModelType Framework_krasotka.Услуги
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Услуги</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.название)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.название)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.цена)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.цена)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.продолжительность)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.продолжительность)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
