# Simple .NET Web API – Basic Math & Utility Endpoints

This project is a very simple **.NET Web API** created for learning purposes.  
It contains 3 controllers, and each controller includes 4 basic endpoints.  
All endpoints perform simple operations without using a database or models.

---

##  Controllers Overview

### 1) MathController
Provides basic math operations.

**Endpoints:**
- GET `/api/math/add?a=5&b=3` → Adds two numbers  
- GET `/api/math/subtract?a=5&b=3` → Subtracts two numbers  
- GET `/api/math/multiply?a=5&b=3` → Multiplies two numbers  
- GET `/api/math/divide?a=6&b=2` → Divides two numbers  

---

### 2) StringController
Provides simple string operations.

**Endpoints:**
- GET `/api/string/uppercase?text=hello` → Converts text to uppercase  
- GET `/api/string/lowercase?text=HELLO` → Converts text to lowercase  
- GET `/api/string/length?text=hello` → Returns text length  
- GET `/api/string/reverse?text=hello` → Reverses the text  

---

### 3) NumberController
Provides simple number utilities.

**Endpoints:**
- GET `/api/number/is-even?number=4` → Checks if number is even  
- GET `/api/number/is-odd?number=5` → Checks if number is odd  
- GET `/api/number/square?number=4` → Returns the square  
- GET `/api/number/cube?number=3` → Returns the cube  

---

##  How to Run the Project

### Requirements
- .NET SDK 7 or 8  
- Any editor (VS Code, Rider, Visual Studio)

### Run the API
Inside the project folder, run:

```bash
dotnet run
