const Motherboard = ["Gigabyte B550M AORUS ELITE", "ASUS TUF GAMING B550-PLUS", "ASUS ROG STRIX X670E-F GAMING WIFI"]
const CPU = ["Intel Core i5-10600KF", "AMD Ryzen", "Intel Core i3-10300", "AMD Ryzen 5 5500", "Intel Core i9-13900KF"]
const GPU = ["ASUS Dual GeForce RTX 3060 OC V2", "MSI GeForce® GT 710", "ASUS Dual Radeon™ RX 6600"]
const RAM = ["Gigabyte AORUS RGB 16 GB", "Kingfast Memória", "Thermaltake Tough"]
const Memory = ["Verbatim Vi550 Solid State Drive SSD", "HDD SEAGATE BarraCuda", "WD Red Plus 14TB HDD"]
const Monitor = ["Acer Nitro VG240YS3bmiipx ZeroFrame Gaming", "LG 34WP65CP-B Ívelt UltraWide", "MSI G2712"]
const Billentyűzet = ["White Shark GK-2022B/R-HU SHINOBI", "Razer Huntsman Mini", "White Shark GK-2022W/BL-HU SHINOBI"]
const Eger = ["Logitech G502 Hero", "Logitech G PRO Hero", "Logitech G502 LightSpeed Hero"]
let osszar = 0;
let MBlegutobbi = 0
let CPUlegutobbi = 0 
let GPUlegutobbi = 0 
let RAMlegutobbi = 0 
let Mlegutobbi = 0 
let MOlegutobbi = 0 
let BILLlegutobbi = 0 
let EGERlegutobbi = 0 
function Check(x)
{    
    document.getElementById(x).innerHTML = ""
}

function MBSelect(div,sorszam,ar)
{
    
    document.getElementById("MB").innerHTML = `${Motherboard[sorszam]}`
    osszar -= MBlegutobbi;
    osszar += ar;
    document.getElementById("osszar").innerHTML = osszar + " Ft"
    MBlegutobbi = ar;
}
function CPUSelect(div,sorszam,ar)
{
    osszar -= CPUlegutobbi;
    document.getElementById("CPU").innerHTML = `${CPU[sorszam]}`
    osszar += ar;
    document.getElementById("osszar").innerHTML = osszar + " Ft"
    CPUlegutobbi = ar;
}
function GPUSelect(div,sorszam,ar)
{
    osszar -= GPUlegutobbi;
    document.getElementById("GPU").innerHTML = `${GPU[sorszam]}`
    osszar += ar;
    document.getElementById("osszar").innerHTML = osszar + " Ft"
    GPUlegutobbi = ar;
}
function RAMSelect(div,sorszam,ar)
{
    osszar -= RAMlegutobbi;
    document.getElementById("RAM").innerHTML = `${RAM[sorszam]}`
    osszar += ar;
    document.getElementById("osszar").innerHTML = osszar + " Ft"
    RAMlegutobbi = ar;
}
function MSelect(div,sorszam,ar)
{
    osszar -= Mlegutobbi;
    document.getElementById("M").innerHTML = `${Memory[sorszam]}`
    osszar += ar;
    document.getElementById("osszar").innerHTML = osszar + " Ft"
    Mlegutobbi = ar;
}
function MOSelect(div,sorszam,ar)
{
    osszar -= MOlegutobbi;
    document.getElementById("MO").innerHTML = `${Monitor[sorszam]}`
    osszar += ar;
    document.getElementById("osszar").innerHTML = osszar + " Ft"
    MOlegutobbi = ar;
}
function BILLSelect(div,sorszam,ar)
{
    osszar -= BILLlegutobbi;
    document.getElementById("BILL").innerHTML = `${Billentyűzet[sorszam]}`
    osszar += ar;
    document.getElementById("osszar").innerHTML = osszar + " Ft"
    BILLlegutobbi = ar;
}
function EGERSelect(div,sorszam,ar)
{
    osszar -= EGERlegutobbi;
    document.getElementById("EGER").innerHTML = `${Eger[sorszam]}`
    osszar += ar;
    document.getElementById("osszar").innerHTML = osszar + " Ft"
    EGERlegutobbi = ar;
}