@ModelType Framework_krasotka.Услуги
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
