@ModelType Application02.color
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>color</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.color1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.color1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.estado)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.estado)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id_color }) |
    @Html.ActionLink("Back to List", "Index")
</p>
