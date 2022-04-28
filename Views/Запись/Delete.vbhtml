@ModelType Framework_krasotka.Запись
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
