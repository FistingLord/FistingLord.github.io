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
    Public Class ЗаписьController
        Inherits System.Web.Mvc.Controller

        Private db As New Database1Entities

        ' GET: Запись
        Function Index() As ActionResult
            Return View(db.Запись.ToList())
        End Function

        ' GET: Запись/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim запись As Запись = db.Запись.Find(id)
            If IsNothing(запись) Then
                Return HttpNotFound()
            End If
            Return View(запись)
        End Function

        ' GET: Запись/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Запись/Create
        'Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        'сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,фамилия,имя,отчество,пол,услуга,дата,время")> ByVal запись As Запись) As ActionResult
            If ModelState.IsValid Then
                db.Запись.Add(запись)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(запись)
        End Function

        ' GET: Запись/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim запись As Запись = db.Запись.Find(id)
            If IsNothing(запись) Then
                Return HttpNotFound()
            End If
            Return View(запись)
        End Function

        ' POST: Запись/Edit/5
        'Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        'сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,фамилия,имя,отчество,пол,услуга,дата,время")> ByVal запись As Запись) As ActionResult
            If ModelState.IsValid Then
                db.Entry(запись).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(запись)
        End Function

        ' GET: Запись/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim запись As Запись = db.Запись.Find(id)
            If IsNothing(запись) Then
                Return HttpNotFound()
            End If
            Return View(запись)
        End Function

        ' POST: Запись/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim запись As Запись = db.Запись.Find(id)
            db.Запись.Remove(запись)
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
