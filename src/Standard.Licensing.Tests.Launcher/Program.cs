using Standard.Licensing.Tests;
using System;

namespace Standard.Licensing.Tests.Launcher
{
    class Program
    {
        // Je n'arrive pas à faire fonctionner les tests unitaires
        // => je les lance à la main depuis une console
        static void Main(string[] args)
        {
            Console.WriteLine("Démarrage des tests");

            var keyGeneratorTests = new KeyGeneratorTests();
            keyGeneratorTests.Ensure_To_Not_Generate_Identical_Keys();

            var licenseSignatureTests = new LicenseSignatureTests();
            licenseSignatureTests.Init();
            licenseSignatureTests.Can_Detect_Hacked_License();
            licenseSignatureTests.Can_Generate_And_Validate_Signature_With_Empty_License();
            licenseSignatureTests.Can_Generate_And_Validate_Signature_With_Standard_License();

            var licenseValidationTests = new LicenseValidationTests();
            licenseValidationTests.Can_Validate_CustomAssertion();
            licenseValidationTests.Can_Validate_Expired_ExpirationDate();
            licenseValidationTests.Can_Validate_Invalid_Signature();
            licenseValidationTests.Can_Validate_Valid_Signature();
            licenseValidationTests.Do_Not_Crash_On_Invalid_Data();

            Console.WriteLine("Fin des tests");
            Console.ReadLine();
        }
    }
}
