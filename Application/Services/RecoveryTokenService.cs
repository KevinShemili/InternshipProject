using Application.Persistance;
using System.Security.Cryptography;

namespace Application.Services {
    public class RecoveryTokenService : IRecoveryTokenService {

        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;

        public RecoveryTokenService(IUserVerificationAndResetRepository userVerificationAndResetRepository) {
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
        }

        public async Task<string> GenerateVerificationToken() {
            string token;

            do {
                token = Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
            }
            while (await _userVerificationAndResetRepository.ContainsVerificationTokenAsync(token)); // check if such token already exists
            return token;
        }

        public async Task<string> GeneratePasswordToken() {
            string token;

            do {
                token = Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
            }
            while (await _userVerificationAndResetRepository.ContainsPasswordTokenAsync(token)); // check if such token already exists
            return token;
        }
    }
}
