@ModelType Application02.producto
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>producto</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.producto1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.producto1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.precio)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.precio)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.estado)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.estado)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.categoria.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.categoria.nombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id_producto }) |
    @Html.ActionLink("Back to List", "Index")
</p>
