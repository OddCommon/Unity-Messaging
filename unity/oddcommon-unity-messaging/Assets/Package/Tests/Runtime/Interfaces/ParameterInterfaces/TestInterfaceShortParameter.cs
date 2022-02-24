using OddCommon.Messaging;


[MessagingInterface]
public interface TestInterfaceShortParaeter
{
    void TestMethodShortSignedParameter(short signedShortParam);
    void TestMethodShortUnsignedParameter(ushort unsignedShortParam);
    void TestMethodShortParameter(short signedShortParam, ushort unsignedShortParam);
}