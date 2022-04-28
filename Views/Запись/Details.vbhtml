@ModelType Framework_krasotka.Запись
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Запись</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.фамилия)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.фамилия)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.имя)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.имя)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.отчество)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.отчество)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.пол)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.пол)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.услуга)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.услуга)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.дата)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.дата)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.время)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.время)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
