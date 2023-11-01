string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

string message2 = "What is the value <span>between the tags</span>?";

int openingPosition2 = message2.IndexOf("<span>");
int closingPosition2 = message2.IndexOf("</span>");

openingPosition2 += 6;
int length2 = closingPosition2 - openingPosition2;
Console.WriteLine(message2.Substring(openingPosition2, length2));


string message3 = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition3 = message3.IndexOf('(');
    if (openingPosition3 == -1) break;

    openingPosition3 += 1;
    int closingPosition3 = message3.IndexOf(')');
    int length3 = closingPosition3 - openingPosition3;
    Console.WriteLine(message3.Substring(openingPosition3, length3));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message3 = message3.Substring(closingPosition3 + 1);
}

string message4 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols4 = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition4 = 0;

while (true)
{
    int openingPosition4 = message4.IndexOfAny(openSymbols4, closingPosition4);

    if (openingPosition4 == -1) break;

    string currentSymbol4 = message4.Substring(openingPosition4, 1);

    // Now  find the matching closing symbol
    char matchingSymbol4 = ' ';

    switch (currentSymbol4)
    {
        case "[":
            matchingSymbol4 = ']';
            break;
        case "{":
            matchingSymbol4 = '}';
            break;
        case "(":
            matchingSymbol4 = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition4 += 1;
    closingPosition4 = message4.IndexOf(matchingSymbol4, openingPosition4);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length4 = closingPosition4 - openingPosition4;
    Console.WriteLine(message4.Substring(openingPosition4, length4));
}

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the quantity
int quantityStart = input.IndexOf("<span>");
int quantityEnd = input.IndexOf("</span>");
quantityStart += "<span>".Length; // Added length of the tag so index moves to end of the tag
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength); //Extracts from end of open tag to beginning of close tag
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
output = input.Replace("&trade;", "&reg;");

// Remove the opening <div> tag
int divStart = input.IndexOf("<div>");
int divLength = "<div>".Length;
output = output.Remove(divStart, divLength);

// Remove the closing <div> tag
int divCloseStart = output.IndexOf("</div>");
int divCloseLength = "</div>".Length;
output = output.Remove(divCloseStart, divCloseLength);
output = $"Output: {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);