﻿Option Explicit On
Option Strict On

''' <summary>
''' Clase Especialidad.
''' </summary>
''' <author>Raquel Lloréns Gambín</author>

Public Class TipoPago


    Private _Cod As Integer
    Private _Descripcion As String

    ''' <summary>
    ''' Constructor por defecto
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New()
        _Cod = 0
        _Descripcion = ""
    End Sub

    ''' <summary>
    ''' Constructor con todos los parámetros
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New(ByVal c As Integer, ByVal d As String)
        _Cod = c
        _Descripcion = d
    End Sub

    ''' <summary>
    ''' Constructor de copia
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub New(ByVal nuevoTipoPago As TipoPago)
        _Cod = nuevoTipoPago.Cod()
        _Descripcion = nuevoTipoPago.Descripcion()
    End Sub

    ''' <summary>
    ''' Destructor Dispose
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Public Sub Dispose()
        _Cod = 0
        _Descripcion = ""
    End Sub

    ''' <summary>
    ''' Propiedades de los atributos
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>

    Public Property Cod() As Integer
        Get
            Return _Cod
        End Get
        Set(ByVal value As Integer)
            _Cod = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    ''' <summary>
    ''' Destructor Finalize
    ''' </summary>
    ''' <author>Raquel Lloréns Gambín</author>
    Protected Overrides Sub Finalize()
        _Cod = 0
        _Descripcion = ""
    End Sub

End Class



