@ModelType Application02.talla
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>talla</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.talla1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.talla1)
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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id_talla }) |
    @Html.ActionLink("Back to List", "Index")
</p>
