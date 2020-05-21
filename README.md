<!--Category:PowerShell--> 
 <p align="right">
    <a href="https://www.powershellgallery.com/packages/ProductivityTools.PSDisplayPosition/"><img src="Images/Header/Powershell_border_40px.png" /></a>
    <a href="http://www.productivitytools.tech/display-position/"><img src="Images/Header/ProductivityTools_green_40px_2.png" /><a> 
    <a href="https://github.com/pwujczyk/ProductivityTools.PSDisplayPosition"><img src="Images/Header/Github_border_40px.png" /></a>
</p>
<p align="center">
    <a href="http://http://productivitytools.tech/">
        <img src="Images/Header/LogoTitle_green_500px.png" />
    </a>
</p>

# Display position

Module allows to change position of the external display. Additionally it returns information about displays.

<!--more-->
<!--og-image-->
![Display settings](Images/DisplayConfiguration.png) 

Main cmdlet doesn't return any information it just move screen to the chosen side.

```PowerShell
Move-ExternalDisplayToRight -Verbose
```

![Moving display](Images/MovingDisplay.png) 

Getting details of the display returns information about all connected devices.

```PowerShell
Get-DisplayDetails -Verbose
```

![Display details](Images/DisplayDetails.png) 



