# Archive of the C# projects needed to complete my Intro to Programming Course 

| ID | File / Project | Description |

| **01** | `Hello_World.cs` | Basic Hello World program |

| **02** | `Product_Inventory.cs` | Calculates the total value of three product lines by explicitly casting string inputs to `decimal` (currency) and `int` (quantity) for the final summation. |

| **03** | `Interest_Calculator.cs` | Computes a final account balance by applying a standard interest rate formula to user-provided `double` inputs. |

| **04** | `Construction_Cost.cs` | Determines the construction cost per square meter by processing building dimensions and fixed costs, isolating the numerator and denominator variables for readablity. |

| **05** | `Power_Of_Three.cs` | Verifies if an input integer is a perfect power of three by using the Change of Base formula (`Math.Log10`) rather than iterative division. |

| **06** | `Trigonometry_Calc.cs` | Converts input degrees to radians (required by `Math.Sin`/`Cos`) and formats the resulting trigonometric values to fixed-point precision (`:f3`). |

| **07** | `Two_Digit_Input_Sum.cs` | Continuously sums two-digit integers (10-99) while rejecting invalid inputs via `continue` and terminating on a specific sentinel value (100). |

| **08** | `Sum_Until_Threshold.cs` |Accumulates user-provided integers into a running total, terminating the loop only once the sum exceeds a defined sentinel cap. |

| **09** | `Triangle_Pattern.cs` | Generates a right-angled triangle of variable height using nested `for` loops to control row count and character repetition per row.|

| **10** | `Exam_Score_Stats.cs` | Populates a fixed-size `double` array with scores to compute the average, utilizing `Array.Sort` to isolate and retrieve the maximum value. |

| **11** | `Even_Odd_Sorter.cs` | Filters a user-defined set of integers into separate "Even" and "Odd" arrays using a two-pass approach (counting parity first to dimension the arrays, then populating them). |

| **12** | `Reverse_Alpha_Sort.cs` | Sorts a character array alphabetically using `Array.Sort`, then manually iterates backward using `n - (j + 1)` indexing to display the sequence in descending order. |

| **13** | `Temp_Converter.cs` |  Performs bidirectional temperature conversion (C↔F) using dedicated static methods to isolate the mathematical formulas from the main selection loop. |

| **14** | `Sphere_Geometry.cs` | Calculates sphere circumference and surface area using a static `radius` field, allowing multiple methods to access the data without parameter passing. |

| **15** | `GUI_Calculator` | A basic GUI calculator that handles `Click` events to parse text boxes, execute arithmetic based on the operator field, and display results or error diagnostics. |

---

## 🚀 Usage

### Console Apps (01-14)
Run individual files via the .NET CLI:
```bash
GUI App (15)

Open the solution in Visual Studio and launch the debugger (F5).
dotnet run
