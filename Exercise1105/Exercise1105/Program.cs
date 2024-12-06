using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

// ================================ NAMESPACE =================================
// Räknar ut moms med default på 25%.
// ============================================================================
namespace Exercise1105
{

    // ================================ KLASS =================================
    // Program. Innehåller Main-metoden.
    // ========================================================================
    internal class Program
    {

        private const double defaultVAT = 0.25;

        // ============================== METOD ===============================
        // Main. Start på programmet.
        // ====================================================================
        static void Main(string[] args)
        {
            printReceipt(100.0, 0.30, addVAT(100.0, 0.30));
            printReceipt(100.0, defaultVAT, addVAT(100.0));
            printReceipt(1000, 0.10, addVAT(1000, 0.10));

        }

        // ============================== METOD ===============================
        // addVAT. Överlagring med inmatning summa. Räknar ut ny summa
        // inklusivt moms på 25%. Returnerar den nya summan.
        // ====================================================================
        static double addVAT(double subtotal)
        {
            double total = addVAT(subtotal, defaultVAT);
            return total;
        }

        // ============================== METOD ===============================
        // addVAT. Överlagring med inmatning summa och moms. Räknar ut ny summa
        // inklusivt moms. Returnerar den nya summan.
        // ====================================================================
        static double addVAT(double subtotal, double vat)
        {
            double total = subtotal + subtotal * vat;
            return total;
        }

        // ============================== METOD ===============================
        // printReceipt. Skriver ut summa utan VAT, VAT och summa inklusivt
        // VAT.
        // ====================================================================
        static void printReceipt(double subtotal, double vat, double total)
        {
            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("VAT: " + vat);
            Console.WriteLine("Total: " + total);
            Console.WriteLine();
        }

    }
}
