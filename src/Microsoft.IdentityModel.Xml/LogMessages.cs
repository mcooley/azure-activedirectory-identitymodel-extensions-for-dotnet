//------------------------------------------------------------------------------
//
// Copyright (c) Microsoft Corporation.
// All rights reserved.
//
// This code is licensed under the MIT License.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files(the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions :
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//------------------------------------------------------------------------------

namespace Microsoft.IdentityModel.Xml
{
    /// <summary>
    /// Log messages and codes for XmlProcessing
    /// Range: IDX21010 - IDX21200
    /// </summary>
    internal static class LogMessages
    {
#pragma warning disable 1591
        // XML reading
        internal const string IDX21011 = "IDX21011: Unable to read XML. Expecting XmlReader to be at ns.element: '{0}.{1}', found: '{2}.{3}'.";
        internal const string IDX21013 = "IDX21013: Unable to read XML. While reading element '{0}', Required attribute was not found : '{1}'.";
        internal const string IDX21015 = "IDX21015: Only a single '{0}' element is supported. Found more than one.";
        internal const string IDX21016 = "IDX21016: Exception thrown while reading '{0}'. See inner exception for more details.";
        internal const string IDX21017 = "IDX21017: Exception thrown while reading '{0}'. Caught exception: '{1}'.";
        internal const string IDX21019 = "IDX21019: Unable to read XML. A second <Signature> element was found. The EnvelopedSignatureReader can only process one <Signature>.";
        internal const string IDX21020 = "IDX21020: Unable to read XML. A second <Reference> element was found. The EnvelopedSignatures can only have one <Reference>.";
        internal const string IDX21022 = "IDX21022: Unable to read XML. Expecting XmlReader to be at a StartElement, NodeType is: '{0}'.";
        internal const string IDX21024 = "IDX21024: Unable to read XML. Expecting XmlReader to be at element: '{0}', found: '{1}'.";
        internal const string IDX21025 = "IDX21025: Unable to read XML. Expecting XmlReader to be at EndElement: '{0}'. Found XmlNode 'type.name': '{1}.{2}'.";

        // XML structure, supported exceptions
        internal const string IDX21100 = "IDX21100: Unable to process the {0} element. This canonicalization method is not supported: '{1}'. Supported methods are: '{2}', '{3}', '{4}'.";
        internal const string IDX21105 = "IDX21105: Transform must specify an algorithm none was found.";
        internal const string IDX21107 = "IDX21107: 'InclusiveNamespaces' is not supported.";

        // signature validation
        internal const string IDX21200 = "IDX21200: The 'Signature' did not validate. CryptoProviderFactory: '{0}', SecurityKey: '{1}'.";
        internal const string IDX21201 = "IDX21201: The 'Reference' did not validate: '{0}'.";
        internal const string IDX21202 = "IDX21202: The Reference does not have a XmlTokenStream set: '{0}'.";
        internal const string IDX21203 = "IDX21203: The CryptoProviderFactory: '{0}', CreateForVerifying returned null for key: '{1}', SignatureMethod: '{2}'.";
        internal const string IDX21204 = "IDX21204: Canonicalization algorithm is not supported: '{0}'. Supported methods are: '{1}', '{2}'.";
        internal const string IDX21206 = "IDX21206: The reference '{0}' did not contain a digest.";
        internal const string IDX21207 = "IDX21207: SignatureMethod is not supported: '{0}'. CryptoProviderFactory: '{1}'.";
        internal const string IDX21208 = "IDX21208: DigestMethod is not supported: '{0}'. CryptoProviderFactory: '{1}'.";
        internal const string IDX21209 = "IDX21209: The CryptoProviderFactory: '{0}', CreateHashAlgorithm, returned null for DigestMethod: '{1}'.";
        internal const string IDX21210 = "IDX21210: The TransformFactory does not support the transform: '{0}'.";

        // logging messages
        internal const string IDX21300 = "IDX21300: KeyInfo skipped unknown element: '{0}'.";

        // XML writing
        internal const string IDX21401 = "IDX21401: Unable to write XML. {0}.{1} is null or empty.";
        internal const string IDX21403 = "IDX21402: Unable to write XML. One of the values in Reference.Transforms is null or empty.";
        internal const string IDX21404 = "IDX21401: Unable to write XML. Signature.SignedInfo is null.";
        internal const string IDX21405 = "IDX21405: Unable to write XML. SignedInfo.Reference is null.";

        // XML validation
        internal const string IDX21500 = "IDX21500: xsi:type attribute was not found. Expected: '{0}':'{1}'.";
        internal const string IDX21501 = "IDX21501: xsi:type attribute was did not match. Expected: '{0}':'{1}', Found: '{2}':'{3}'.";
#pragma warning restore 1591
    }
}
