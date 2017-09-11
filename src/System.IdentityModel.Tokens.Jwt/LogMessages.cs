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

namespace System.IdentityModel.Tokens.Jwt
{
    /// <summary>
    /// Log messages and codes
    /// </summary>
    internal static class LogMessages
    {
        #pragma warning disable 1591
        // token creation
        internal const string IDX10401 = "IDX10401: Expires: '{0}' must be after NotBefore: '{1}'.";

        // signature creation / validation
        internal const string IDX10508 = "IDX10508: Signing JWT is not supported for: Algorithm: '{0}', SecurityKey: '{1}'.";

        // JWT messages
        internal const string IDX10700 = "IDX10700: Error found while parsing date time. The '{0}' claim has value '{1}' which is could not be parsed to an integer.";
        internal const string IDX10701 = "IDX10701: Error found while parsing date time. The '{0}' claim has value '{1}' does not lie in the valid range.";
        internal const string IDX10706 = "IDX10706: '{0}' can only write SecurityTokens of type: '{1}', 'token' type is: '{2}'.";
        internal const string IDX10709 = "IDX10709: JWT is not well formed: '{0}'.\nThe token needs to be in JWS or JWE Compact Serialization Format. (JWS): 'EncodedHeader.EndcodedPayload.EncodedSignature'. (JWE): 'EncodedProtectedHeader.EncodedEncryptedKey.EncodedInitializationVector.EncodedCiphertext.EncodedAuthenticationTag'.";
        internal const string IDX10710 = "IDX10710: Only a single 'Actor' is supported. Found second claim of type: '{0}', value: '{1}'";
        internal const string IDX10711 = "IDX10711: actor.BootstrapContext is not a string AND actor.BootstrapContext is not a JWT";
        internal const string IDX10712 = "IDX10712: actor.BootstrapContext is null. Creating the token using actor.Claims.";
        internal const string IDX10713 = "IDX10713: Creating actor value using actor.BootstrapContext(as string)";
        internal const string IDX10714 = "IDX10714: Creating actor value using actor.BootstrapContext.rawData";
        internal const string IDX10715 = "IDX10715: Creating actor value by writing the JwtSecurityToken created from actor.BootstrapContext";
        internal const string IDX10716 = "IDX10716: Decoding token: '{0}' into header, payload and signature.";
        internal const string IDX10720 = "IDX10720: Token string does not match the token formats: JWE (header.encryptedKey.iv.ciphertext.tag) or JWS (header.payload.signature)";
        internal const string IDX10721 = "IDX10721: Creating JwtSecurityToken: Issuer: '{0}', Audience: '{1}'";
        internal const string IDX10722 = "IDX10722: Creating security token from the header: '{0}', payload: '{1}' and raw signature: '{2}'.";
        internal const string IDX10723 = "IDX10723: Unable to decode the payload '{0}' as Base64Url encoded string. jwtEncodedString: '{1}'.";
        internal const string IDX10729 = "IDX10729: Unable to decode the header '{0}' as Base64Url encoded string. jwtEncodedString: '{1}'.";
        internal const string IDX10730 = "IDX10730: Failed to create the token encryption provider.";
        internal const string IDX10733 = "IDX10733: Unable to obtain a CryptoProviderFactory, both EncryptingCredentials.CryptoProviderFactory and EncryptingCredentials.Key.CrypoProviderFactory are both null.";
        internal const string IDX10735 = "IDX10735: If JwtSecurityToken.InnerToken != null, then JwtSecurityToken.Header.EncryptingCredentials must be set.";
        internal const string IDX10736 = "IDX10736: JwtSecurityToken.SigningCredentials is not supported when JwtSecurityToken.InnerToken is set.";
        internal const string IDX10737 = "IDX10737: EncryptingCredentials set on JwtSecurityToken.InnerToken is not supported.";
        internal const string IDX10738 = "IDX10738: Header.Cty != null, assuming JWS. Cty: '{0}'.";

        // logging
        internal const string IDX10645 = "IDX10645: Creating raw signature using the signature credentials.";
#pragma warning restore 1591
    }
}
