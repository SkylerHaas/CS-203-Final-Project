Public Class Motorcycle
    Private mYear As Integer
    Private mMake As String
    Private mModel As String
    Private mBodyStyle As String
    Private mMilage As Integer
    Private mCondition As String
    Private mEngineSize As Integer
    Private mEngineCylinders As Integer
    Private mPrice As Decimal

    Public Sub New(ByVal pYear As Integer, ByVal pMake As String, ByVal pModel As String, ByVal pBodyStyle As String, ByVal pMilage As Integer, ByVal pCondition As String, ByVal pEngineSize As Integer, ByVal pEngineCylinders As Integer, ByVal pPrice As Decimal)
        mYear = pYear
        mMake = pMake
        mModel = pModel
        mBodyStyle = pBodyStyle
        mMilage = pMilage
        mCondition = pCondition
        mEngineSize = pEngineSize
        mEngineCylinders = pEngineCylinders
        mPrice = pPrice
    End Sub

    Public ReadOnly Property Year As Integer
        Get
            Return mYear
        End Get
    End Property

    Public ReadOnly Property Make As String
        Get
            Return mMake
        End Get
    End Property

    Public ReadOnly Property Model As String
        Get
            Return mModel
        End Get
    End Property

    Public ReadOnly Property BodyStyle As String
        Get
            Return mBodyStyle
        End Get
    End Property

    Public ReadOnly Property Milage As Integer
        Get
            Return mMilage
        End Get
    End Property

    Public ReadOnly Property Condition As String
        Get
            Return mCondition
        End Get
    End Property

    Public ReadOnly Property EngineSize As Integer
        Get
            Return mEngineSize
        End Get
    End Property

    Public ReadOnly Property EngineCylinders As Integer
        Get
            Return mEngineCylinders
        End Get
    End Property

    Public ReadOnly Property Price As Decimal
        Get
            Return mPrice
        End Get
    End Property

End Class
