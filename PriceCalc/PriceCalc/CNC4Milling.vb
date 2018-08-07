﻿Public Class CNC4Milling
    Inherits Machines
    Property MinRate As Decimal = 1.9D
    Property CostCenter As String = "B-269"
    Property Name As String = "CNC 4 Axe"
    Public Overrides Function SetupHourRate(minWorked As Decimal, minRate As Decimal, qtyRate As Integer) As Decimal
        SetupHourRate = MyBase.SetupHourRate(minWorked, minRate, qtyRate)
    End Function

    Public Overrides Function MachineHourRate(minWorked As Decimal, minRate As Decimal, qtyRate As Integer) As Decimal
        MachineHourRate = MyBase.MachineHourRate(minWorked, minRate, qtyRate)
    End Function
End Class
