Feature: Practica 
@Chrome
Scenario: carrito de compras
Given ingresa a la pagina web "https://www.ebay.com/"
When ingresa la caja de texto de busqueda "DRESS"
And click boton buscar
And sobrepongo el mouse en el contro
And click en lista
And click producto 
And click en seleccionar color "Pink"
And click en seleccionar size "S"
And click agregar a carrito 
Then verificar name del producto "Elegant Fashion Women Sexy Boat Neck Glitter Dress Evening Party Formal Dress"
When ingresa la caja de texto de busqueda "DRESS"
And click boton buscar
And click en link del producto 
And click en select color "A#"
And click en select size "M"
And click agregar a carrito
Then verificar name del producto "Women Sleeveless Summer Boho Printed Beach Casual Loose Mini Shirt Beach Dress"






