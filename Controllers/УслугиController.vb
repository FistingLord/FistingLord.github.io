Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Framework_krasotka

Namespace Controllers
    Public Class УслугиController
        Inherits System.Web.Mvc.Controller

        Private db As New Database1Entities

        ' GET: Услуги
        Function Index() As ActionResult
            Return View(db.Услуги.ToList())
        End Function

        ' GET: Услуги/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim услуги As Услуги = db.Услуги.Find(id)
            If IsNothing(услуги) Then
                Return HttpNotFound()
            End If
            Return View(услуги)
        End Function

        ' GET: Услуги/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Услуги/Create
        'Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        'сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,название,цена,продолжительность")> ByVal услуги As Услуги) As ActionResult
            If ModelState.IsValid Then
                db.Услуги.Add(услуги)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(услуги)
        End Function

        ' GET: Услуги/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim услуги As Услуги = db.Услуги.Find(id)
            If IsNothing(услуги) Then
                Return HttpNotFound()
            End If
            Return View(услуги)
        End Function

        ' POST: Услуги/Edit/5
        'Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        'сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,название,цена,продолжительность")> ByVal услуги As Услуги) As ActionResult
            If ModelState.IsValid Then
                db.Entry(услуги).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(услуги)
        End Function

        ' GET: Услуги/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim услуги As Услуги = db.Услуги.Find(id)
            If IsNothing(услуги) Then
                Return HttpNotFound()
            End If
            Return View(услуги)
        End Function

        ' POST: Услуги/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim услуги As Услуги = db.Услуги.Find(id)
            db.Услуги.Remove(услуги)
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
