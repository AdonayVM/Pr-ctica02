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
    Public Class tallasController
        Inherits System.Web.Mvc.Controller

        Private db As New inventariosEntities

        ' GET: tallas
        Function Index() As ActionResult
            Return View(db.tallas.ToList())
        End Function

        ' GET: tallas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim talla As talla = db.tallas.Find(id)
            If IsNothing(talla) Then
                Return HttpNotFound()
            End If
            Return View(talla)
        End Function

        ' GET: tallas/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: tallas/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id_talla,talla1,estado")> ByVal talla As talla) As ActionResult
            If ModelState.IsValid Then
                db.tallas.Add(talla)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(talla)
        End Function

        ' GET: tallas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim talla As talla = db.tallas.Find(id)
            If IsNothing(talla) Then
                Return HttpNotFound()
            End If
            Return View(talla)
        End Function

        ' POST: tallas/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id_talla,talla1,estado")> ByVal talla As talla) As ActionResult
            If ModelState.IsValid Then
                db.Entry(talla).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(talla)
        End Function

        ' GET: tallas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim talla As talla = db.tallas.Find(id)
            If IsNothing(talla) Then
                Return HttpNotFound()
            End If
            Return View(talla)
        End Function

        ' POST: tallas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim talla As talla = db.tallas.Find(id)
            db.tallas.Remove(talla)
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
