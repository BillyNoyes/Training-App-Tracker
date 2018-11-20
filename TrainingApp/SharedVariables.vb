'Imports the database connection library
Imports System.Data
Imports System.Data.OleDb
Module SharedVariables
    'Declares the public variable conAppDatabase as OleDbConnection
    Public conAppDatabase As New OleDbConnection
    'Declares the public variable dtasetAppDatabase as a new DataSet
    Public dtasetAppDatabase As New DataSet
    'Declares the public variable dtaadpPdet as OleDbDataAdapter
    Public dtaadpPdet As New OleDbDataAdapter
    'Declares the public variable sqlcmdbldPdet as OleDbCommandBuilder(dtaadpPdet)
    Public sqlcmdbldPdet As New OleDbCommandBuilder(dtaadpPdet)

    'Declares the public variable dtaadpComparison as OleDbDataAdapter
    Public dtaadpComparison As New OleDbDataAdapter
    'Declares the public variable dtaadpTeam as OleDbDataAdapter
    Public dtaadpTeam As New OleDbDataAdapter
    'Declares the public variable dtaadpTraining_Details as OleDbDataAdapter
    Public dtaadpTraining_Details As New OleDbDataAdapter
    'Declares the public variable sqlcmdbldPersonalDetails as OleDbCommandBuilder(dtaadpPdet)
    Public sqlcmdbldPersonalDetails As New OleDbCommandBuilder(dtaadpPdet)
    'Declares the public variable ID as Integer
    Public ID As Integer
    Public Sub Connect()
        'The Public sub used for connecting each form to the SharedVariable module
        'SharedVariable - Method of creating a process for connecting to Microsoft Access which can then be used across all of the forms without having to retype it everytime
        'Declares the variable DriveLetter as character
        Dim DriveLetter As Char
        'Initializes the varaible DriveLetter as the startup path for the application
        DriveLetter = Application.StartupPath.Substring(0, 1)
        'Initializes the Database connection as the datasource and driveletter location
        conAppDatabase.ConnectionString = "Provider=Microsoft.ACE.OleDB.12.0;Data Source=" & DriveLetter & ":\CG2 (2014-2015)\AppDatabase.accdb"
    End Sub
End Module
