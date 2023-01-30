namespace Tutoree.Utils.Interface
{
    public interface IJwtService
    {
        public string GenerateToken(string data);

        public string VerifyToken(string token);
    }
}
