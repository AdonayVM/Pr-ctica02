Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Application02

Namespace Controllers
    Public Class productoesController
        Inherits System.Web.Mvc.Controller

        Private db As New inventariosEntities

        ' GET: productoes
        Function Index() As ActionResult
            Dim productoes = db.productoes.Include(Function(p) p.categoria)
            Return View(productoes.ToList())
        End Function

        ' GET: productoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim producto As producto = db.productoes.Find(id)
            If IsNothing(producto) Then
                Return HttpNotFound()
            End If
            Return View(producto)
        End Function

        ' GET: productoes/Create
        Function Create() As ActionResult
            ViewBag.id_categoria = New SelectList(db.categorias, "id_categoria", "nombre")
            Return View()
        End Function

        ' POST: productoes/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id_producto,producto1,precio,id_categoria,estado")> ByVal producto As producto) As ActionResult
            If ModelState.IsValid Then
                db.productoes.Add(producto)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.id_categoria = New SelectList(db.categorias, "id_categoria", "nombre", producto.id_categoria)
            Return View(producto)
        End Function

        ' GET: productoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim producto As producto = db.productoes.Find(id)
            If IsNothing(producto) Then
                Return HttpNotFound()
            End If
            ViewBag.id_categoria = New SelectList(db.categorias, "id_categoria", "nombre", producto.id_categoria)
            Return View(producto)
        End Function

        ' POST: productoes/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id_producto,producto1,precio,id_categoria,estado")> ByVal producto As producto) As ActionResult
            If ModelState.IsValid Then
                db.Entry(producto).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.id_categoria = New SelectList(db.categorias, "id_categoria", "nombre", producto.id_categoria)
            Return View(producto)
        End Function

        ' GET: productoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim producto As producto = db.productoes.Find(id)
            If IsNothing(producto) Then
                Return HttpNotFound()
            End If
            Return View(producto)
        End Function

        ' POST: productoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim producto As producto = db.productoes.Find(id)
            db.productoes.Remove(producto)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
