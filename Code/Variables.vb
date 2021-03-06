﻿Public Class Variables
    Public Shared btnClicked As Boolean = False
    Public Shared waitCount As Long
    Public Shared loot As String
    Public Shared Xp As Integer
    Public Shared healthpotions As Integer
    Public Shared energypotions As Integer

    Structure PlayerStats
        'Player stats
        Shared PlayerCla As String
        Shared PlayerLvl As String
        Shared PlayerXp As String
        Shared VIT As Integer
        Shared STR As Integer
        Shared INT As Integer
        Shared AGI As Integer
        Shared ENR As Integer
        Shared LVL As Integer
    End Structure

    Structure PlayerCombat
        'Player combat stats
        Shared Stunactive As String
        Shared EVA As Integer
        Shared Hitpoints As Integer
        Shared Blockpoints As Integer
        Shared DEF As Integer
    End Structure

    Structure EnemyGenerating
        'Enemy Generating
        Shared EnemyNo As Integer 'processing
        Shared EnemyNa As String
    End Structure

    Structure EnemyCombat
        'Enemy combat stats
        Shared EEVA As Integer 'processing
        Shared EDAM As Integer 'processing
        Shared EDEF As Integer 'processing
    End Structure
End Class
