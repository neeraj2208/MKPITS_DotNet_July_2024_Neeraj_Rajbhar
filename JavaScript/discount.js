function determineDiscount(totalPurchase) 
{
    let discount = 0; 

    if (totalPurchase >= 500) 
    {
        discount = 20; 
    } 
    else if (totalPurchase >= 100)
    {
        discount = 10;  
    } 
    else
    {
        discount = 0;
    }

    let discountAmount = (discount / 100) * totalPurchase;
    let finalAmount = totalPurchase - discountAmount;

 
    console.log('Your total purchase is: ' + totalPurchase);
    if (discount > 0) 
    {
      console.log('You are eligible for a ' + discount + '% discount.');
      console.log('Discount applied: ' + discountAmount);
    } 
    else
    {
        console.log('You are not eligible for a discount.');
    }
    console.log('Final amount to be paid: ' + finalAmount);
}

let totalPurchase = parseFloat(prompt("Enter your total purchase amount:"));
determineDiscount(totalPurchase);
