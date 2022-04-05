@ModelType IEnumerable(Of Application02.talla)
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
            @Html.DisplayNameFor(Function(model) model.talla1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.estado)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.talla1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.estado)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id_talla }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id_talla }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id_talla })
        </td>
    </tr>
Next

</table>
