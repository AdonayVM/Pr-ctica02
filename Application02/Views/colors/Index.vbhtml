@ModelType IEnumerable(Of Application02.color)
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
            @Html.DisplayNameFor(Function(model) model.color1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.estado)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.color1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.estado)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id_color }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id_color }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id_color })
        </td>
    </tr>
Next

</table>
