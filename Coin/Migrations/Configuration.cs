namespace Coin.Migrations
{
    using Coin.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Coin.Models.CoinDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Coin.Models.CoinDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.`
            context.Database.ExecuteSqlCommand("DELETE FROM [Users]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Users', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [News]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('News', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Currencies]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Currencies', RESEED, 0)");
            context.Users.AddOrUpdate(new User()
            {
                Id = 1,
                Name = "Nguyễn Đăng Bằng",
                Phone = "0912345670",
                Email = "nguyendangbanghn@gmail.com",
                Password = "123456",
                Role = UserRole.Admin,
                Status = UserStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10,-5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Users.AddOrUpdate(new User()
            {
                Id=2,
                Name = "Phan Hồng Trường",
                Phone = "0912345671",
                Email = "phanhongtruong@gmail.com",
                Password = "123456",
                Role = UserRole.Author,
                Status = UserStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Users.AddOrUpdate(new User()
            {
                Id=3,
                Name = "Lê Bá Vành",
                Phone = "0912345672",
                Email = "lebavanh@gmail.com",
                Password = "123456",
                Role = UserRole.User,
                Status = UserStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Users.AddOrUpdate(new User()
            {
                Id=4,
                Name = "Lê Bá Quỳnh",
                Phone = "0912345673",
                Email = "lebaquynh@gmail.com",
                Password = "123456",
                Role = UserRole.User,
                Status = UserStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Users.AddOrUpdate(new User()
            {
                Id=5,
                Name = "Lê Bá Đạo",
                Phone = "0912345674",
                Email = "lebadao@gmail.com",
                Password = "123456",
                Role = UserRole.User,
                Status = UserStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Users.AddOrUpdate(new User()
            {
                Id=6,
                Name = "Phùng Khắc Khoan",
                Phone = "0912345675",
                Email = "phungkhackhoan@gmail.com",
                Password = "123456",
                Role = UserRole.User,
                Status = UserStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Users.AddOrUpdate(new User()
            {
                Id=7,
                Name = "Phùng Khắc Đức",
                Phone = "0912345676",
                Email = "phungkhacduc@gmail.com",
                Password = "123456",
                Role = UserRole.User,
                Status = UserStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Users.AddOrUpdate(new User()
            {
                Id=8,
                Name = "Phùng Khắc Chân",
                Phone = "0912345677",
                Email = "phungkhacchan@gmail.com",
                Password = "123456",
                Role = UserRole.User,
                Status = UserStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Users.AddOrUpdate(new User()
            {
                Id=9,
                Name = "Phùng Khắc Cường",
                Phone = "0912345678",
                Email = "phungkhaccuong@gmail.com",
                Password = "123456",
                Role = UserRole.User,
                Status = UserStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Users.AddOrUpdate(new User()
            {
                Id=10,
                Name = "Phùng Khắc Đậu",
                Phone = "0912345679",
                Email = "phungkhacdau@gmail.com",
                Password = "123456",
                Role = UserRole.User,
                Status = UserStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.SaveChanges();
            //News_________________________________
            context.News.AddOrUpdate(new News()
            {
                Id = 1,
                Title = "Grayscale đã mua 80% tổng số Litecoin được khai thác vào tháng 2",
                Description = "“Bạc kỹ thuật số” dường như đã tìm thấy những người ủng hộ nó trong số các nhà đầu tư tổ chức và được công nhận của Grayscale.",
                Content = "<p>“Bạc kỹ thuật số” dường như đã tìm thấy những người ủng hộ nó trong số các nhà đầu tư tổ chức và được công nhận của Grayscale.</p><p>Nhà quản lý quỹ tiền điện tử Grayscale Investments đã mua phần lớn số Litecoin được khai thác vào tháng trước, dữ liệu từ công cụ thị trường Bybt&nbsp;<a href='https://www.bybt.com/Grayscale'>cho thấy</a>. Grayscale hiện nắm giữ hơn 1.44 triệu Litecoin (248.33 triệu đô la), khiến nó trở thành lượng tiền điện tử lớn thứ ba được nắm giữ của công ty sau Bitcoin và Ethereum.</p><p>Công ty là một trong số ít dịch vụ ở Hoa Kỳ cho phép các nhà đầu tư được công nhận và tổ chức mua tiền điện tử. Nó cung cấp hơn 9 “ủy thác” dựa trên tiền điện tử có sẵn dưới dạng đăng ký hoặc cổ phần có thể&nbsp;<a href='https://www.tapchibitcoin.io/otc-la-gi.html'>giao dịch trên thị trường OTC</a>. Và trong khi Grayscale Bitcoin Trust mang lại số vốn lớn nhất từ các nhà đầu tư, Litecoin dường như cũng đang thu hút lượng người theo dõi của chính nó.</p><p>Các thợ đào đã tạo ra hơn 201,600 Litecoin trong 28 ngày qua. Nhưng khi nguồn cung tăng lên, các khách hàng của Grayscale đang ở phía bên kia chọn phần lớn các đồng coin mới. Trong 30 ngày qua, Litecoin Trust của Grayscale (LTCN) đã mua được 174,900 Litecoin. (Không có giá trị gì khi có thể một số khách hàng đang chuyển Litecoin của họ đến quỹ tín thác hơn là mua nhiều hơn trên thị trường).</p><p>Theo dịch vụ theo dõi&nbsp;<a href='https://www.litecoinblockhalf.com/'>LitecoinBlockHalf</a>, cứ sau 2.5 phút lại thấy một “khối” Litecoin duy nhất được giải quyết bởi các thợ đào — hoặc các thực thể sử dụng tài nguyên máy tính của họ để xác thực các giao dịch để nhận phần thưởng. Các thợ đào, để trang trải chi phí và thu lợi nhuận, bán phần lớn các phần thưởng này trên thị trường mở.</p><p>Các số liệu hiện tại cho thấy, các thợ đào kiếm được hơn 12.5 Litecoin như một phần thưởng. Những con số như vậy có nghĩa là hơn 300 Litecoin được khai thác mỗi giờ và 7,200 Litecoin được khai thác mỗi ngày — nghĩa là tháng Hai đã chứng kiến hơn 201,600 Litecoin được khai thác trong 28 ngày (hoặc 216,000 Litecoin trong khoảng thời gian 30 ngày).</p><p>Với 174,900 Litecoin được đưa vào LTCN, có nghĩa là quỹ đã mua gần 80% tổng số Litecoin mới được khai thác trong tháng qua.</p><div></div><p><a href='http://blockquote%20class%3Dtwitter-tweetp%20lang%3Den%20dir%3Dltrin%20the%20past%20month%20a%20href%3Dhttps//twitter.com/Grayscale?ref_src=twsrc%5Etfw@Grayscale/a%20Trust%20has%20purchased%20over%20174,000%20Litecoin.%20brbrThis%20is%20approx%2080%%20of%20all%20Litecoin%20mined%20last%20month...%20a%20href=https://t.co/5RmDARZ3dypic.twitter.com/5RmDARZ3dy/a/p%E2%80%94%20litecoin%20(@litecoin)%20a%20href=https://twitter.com/litecoin/status/1366536227189620737?ref_src=twsrc%5EtfwMarch%201,%202021/a/blockquote%20script%20async%20src=https://platform.twitter.com/widgets.js%20charset=utf-8/script'></a>“Trong tháng qua, Grayscale Trust đã mua hơn 174,000 Litecoin.</p><p>Đây là khoảng 80% tổng số Litecoin được khai thác vào tháng trước”.</p><p>Trong khi đó, “phí bảo hiểm” khét tiếng của Grayscale cho thấy nhu cầu Litecoin là chưa từng có. Theo bản cáo bạch của công ty, mỗi cổ phiếu LTCN chỉ chứa 15.70 đô la tiền điện tử, trong khi bản thân nó giao dịch ở mức 304.99 đô la trên thị trường mở.</p><p>Đó là mức phí bảo hiểm hơn 1,842.61% mà các nhà đầu tư đang trả để được tiếp xúc với Litecoin thông qua một quỹ được quản lý và an toàn mà không gặp rắc rối trong việc quản lý khóa cá nhân. Nó vượt xa mức cao cấp trên bất kỳ sản phẩm Grayscale nào khác.</p>",
                UserId = 2,
                Status = NewsStatus.Active,
                Type = NewsType.Bronze,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });


            context.News.AddOrUpdate(new News()
            {
                Id = 2,
                Title = "Matter Labs, dự án phát triển Layer-2 trên Ethereum nhận được đầu tư từ nhiều ông lớn",
                Description = "Với nhu cầu mở rộng quy mô Ethereum đạt đến khối lượng lớn, số lượng dự án tài chính phi tập trung và công ty internet rót vốn vào giải pháp layer-2 ngày càng tăng.",
                Content = "<p>Với nhu cầu mở rộng quy mô Ethereum đạt đến khối lượng lớn, số lượng dự án tài chính phi tập trung và công ty internet rót vốn vào giải pháp layer-2 ngày càng tăng.</p><p><img src='https://tapchibitcoin.io/wp-content/uploads/2021/03/ethereum.jpg' alt='ethereum' wh='672,381,672'></p><p>Vòng tài trợ Series A cho giao thức mở rộng quy mô zkSync layer 2 của Matter Labs đã được công bố. Mục tiêu của nó là đưa ngôn ngữ hợp đồng thông minh Solidity lên nền tảng.</p><p>Vòng này được một số tên tuổi lớn trong ngành tiền điện tử và bảo mật internet dẫn dắt bao gồm nhà đầu tư Twitter ban đầu Union Square Ventures (USV), Cloudflare, Firebase, Twilio, MongoDB và ông lớn sàn giao dịch Coinbase.</p><p>Matter Labs lần đầu tiên phát hành sản phẩm layer 2 của mình vào tháng 12/2019 sau khi huy động một khoản tiền không được tiết lộ với các đối tác hạn chế. zkSync&nbsp;<a href='https://twitter.com/zksync/status/1366387870735495169'>tweet</a>:</p><p>“Hân hạnh thông báo một vòng đầu tư hệ sinh thái để trở thành xương sống thanh toán chính của Ethereum – và biến thành một bản tổng hợp ZK tương thích với EVM”.</p><p><strong>Layer 2&nbsp;</strong><strong>đang ngày càng phát triển</strong></p><p>zkSync tăng tốc giao dịch Ethereum bằng cách sử dụng các bản tổng hợp không kiến thức để thực hiện hàng loạt giao dịch và xử lý chúng ngoài chuỗi gốc. Nó cũng có thể cung cấp các đảm bảo bảo mật tương đương với một hợp đồng thông minh bình thường trên layer 1.</p><p>Thông báo cho biết bảo mật sẽ là một yếu tố quan trọng để người dùng quyết định giao dịch với giải pháp layer 2 nào.</p><p>“Cộng đồng tiền điện tử sẽ đặc biệt ưa thích các giải pháp có ít tổn hại nhất về bảo mật, phân quyền và trải nghiệm người dùng”.</p><p>Ngoài ra, hệ sinh thái zkSync có thể phát triển vô hạn, tận dụng khả năng tổng hợp và kết hợp các hiệu ứng mạng. Điều này rất quan trọng đối với những giao thức như Aave, Balancer và Curve, vốn đã có giá trị hàng tỷ đô la.</p><p>zkSync xử lý hơn 1.1 triệu giao dịch và được tích hợp vào một số dApp cũng như nền tảng bao gồm Golem, Numio, StablePay và Storj.</p><p>Matter Labs dự kiến sẽ tích hợp nhiều hơn vào các ví chính như những ví do Coinbase và Huobi cung cấp, nói thêm rằng nó có thể trở thành thanh toán chính của Ethereum.</p><p>“Tất cả người dùng sẽ có thể tạo và có khả năng nạp tiền vào tài khoản của họ trực tiếp từ các sàn giao dịch hoặc dịch vụ trên mạng (ví dụ: Coinbase, Huobi, Binance, Ripio hoặc Moonpay) mà không cần một giao dịch layer 1 nào”.</p><p>Các khoản đầu tư từ vòng hạt giống sẽ được chuyển vào việc đưa các hợp đồng thông minh hoàn chỉnh Turing với Solidity sang zkSync thông qua khung lập trình Zinc của riêng nó. Bài đăng trên blog cho biết testnet (mạng thử nghiệm) công khai cho các hợp đồng thông minh trên zkSync sẽ ra mắt trong vài tháng tới.</p><p><strong>Phí gas lại tăng cao</strong></p><p>Thời gian nghỉ ngơi của phí gas không kéo dài do chi phí giao dịch đang có xu hướng tăng trở lại. Khi các tài sản tiền điện tử lớn bắt đầu có dấu hiệu phục hồi sau đợt điều chỉnh của tuần trước, phí giao dịch trung bình cũng đang tăng lên.</p><p>Theo&nbsp;<a href='https://bitinfocharts.com/comparison/ethereum-transactionfees.html#3m'>BitInfoCharts</a>, phí giao dịch Ethereum trung bình là 13 đô la, giảm so với mức đỉnh 40 đô la vào tuần trước nhưng vẫn không mấy lạc quan sau khi giảm nhẹ vào cuối tuần.</p><p>Ngay cả ở những mức này, các giao dịch vi mô trên mạng là không thể thực hiện được, làm cho nhu cầu về các kênh thanh toán layer 2 như zkSync thậm chí còn lớn hơn.</p>",
                UserId = 2,
                Status = NewsStatus.Active,
                Type = NewsType.Silver,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.News.AddOrUpdate(new News()
            {
                Id = 3,
                Title = "Max Keiser cho biết Bitcoin có thể tăng gấp 300 lần, thay thế vàng và đô la Mỹ",
                Description = "Nhà truyền giáo bitcoin Max Keizer cho biết Bitcoin có thể tăng gấp 300 lần khi nó nhắm mục tiêu vào sự thống trị của đồng đô la Mỹ.",
                Content = "<p>Nhà truyền giáo bitcoin Max Keizer cho biết Bitcoin có thể tăng gấp 300 lần khi nó nhắm mục tiêu vào sự thống trị của đồng đô la Mỹ.</p><p><img src='https://tapchibitcoin.io/wp-content/uploads/2021/03/Max-Keizer.jpg' alt='' wh='672,504,672'></p><p>Bò Bitcoin Max Keizer</p><p>Trong một tập mới của RT, Keiser Report, người ủng hộ Bitcoin chia sẻ một báo cáo của Morgan Stanley rằng tiền điện tử hàng đầu vẫn sẽ là một loại tài sản và là một sự thay thế khả thi cho vàng như một vật lưu trữ giá trị và thay thế cho đô la Mỹ như là một phương tiện trao đổi.</p><p>“Bạn có chấp nhận tiền fiat khi độ biến động bằng 0, nhưng việc mất sức mua có được đảm bảo không? Hay bạn thích bitcoin hơn, nơi có sự biến động nhưng lợi nhuận khi mua được đảm bảo? Đó là hai lựa chọn của bạn”.</p><p>Keizer cho biết thêm rằng King of Crypto gần như thống trị thị trường kim loại quý. Ông dự báo rằng BTC sẽ vượt qua bạc trong vòng vài tháng và đạt được một nửa mức vốn hóa thị trường của vàng vào năm 2021.</p><p>“Một khi nó vượt qua vàng, chỉ còn lại đồng đô la và Bitcoin là kẻ săn mồi đỉnh cao. Đó là con cá mập trong một đại dương đầy cá vàng hoặc các sinh vật phù du, đó là đô la Mỹ.</p><p>Họ in rất nhiều đô la nhưng chúng không đặc biệt mạnh mẽ và chúng sẽ bị tiêu diệt khi Bitcoin thống trị và trở thành tiền tệ dự trữ toàn cầu như chúng tôi từng dự đoán. Morgan Stanley cuối cùng cũng thức tỉnh về điều này.”</p><p>Kaiser chỉ ra rằng khi Bitcoin thay thế vàng và đô la Mỹ, giá trị của loại tiền điện tử hàng đầu sẽ tăng lên theo phương diện địa lý.</p><p>“Tôi đoán nó sẽ cao hơn rất nhiều vì nó phải thay thế vàng. Nó phải thay thế đồng đô la Mỹ. Tổng thị trường có thể cho Bitcoin là 300 nghìn tỷ đô la. Nó hiện là 1 nghìn tỷ đô la. Có một con đường gấp 300 lần để đi từ đây. Sở hữu nó hoặc vui vẻ với cái nghèo.”</p><p></p><ul><li><a href='https://tapchibitcoin.io/max-keizer-chien-thang-cua-ong-joe-biden-se-day-bitcoin-len-400000-do-la.html'>Max Keizer: Chiến thắng của ông Joe Biden sẽ đẩy Bitcoin lên 400,000 đô la</a></li><li><a href='https://tapchibitcoin.io/max-keizer-bitcoin-se-pha-huy-tat-ca-cac-loai-tien-dien-tu-khac.html'>Max Keizer: Bitcoin sẽ phá hủy tất cả các loại tiền điện tử khác</a></li></ul><p>Thạch Sanh</p><p>Theo Dailyhodl</p>",
                UserId = 2,
                Status = NewsStatus.Active,
                Type = NewsType.Bronze,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.News.AddOrUpdate(new News()
            {
                Id = 4,
                Title = "Phân tích kỹ thuật ngày 2 tháng 3: BTC, ETH, XRP, EOS, TRX, DASH, LTC",
                Description = "Bitcoin (BTC) và Ethereum (ETH) đã tăng lên kể từ khi bứt phá lên trên các đường kháng cự ngắn hạn vào ngày 1 tháng 3 năm 2021.",
                Content = "<p>Bitcoin (BTC) và Ethereum (ETH) đã tăng lên kể từ khi bứt phá lên trên các đường kháng cự ngắn hạn vào ngày 1 tháng 3 năm 2021.</p><p>XRP (XRP) đang giao dịch trong phạm vi từ $ 0,36 – $ 0,63, hiện đang ở rất gần với mức hỗ trợ.</p><p>EOS (EOS) đã bứt phá lên trên vùng kháng cự ngang trước khi quay trở lại, có khả năng xác nhận nó là hỗ trợ. Tuy nhiên, nó vẫn chưa bắt đầu bật lên.</p><p>TRON (TRX) và Dash (DASH) đã bứt phá lên trên các vùng kháng cự dài hạn ở mức tương ứng là $ 0,043 và $ 185 và xác nhận chúng là hỗ trợ sau đó.</p><p>Tương tự, Litecoin (LTC) đang trong quá trình xác nhận khu vực $ 170 làm hỗ trợ.</p><p><strong>Bitcoin (BTC)</strong></p><p>Vào ngày 1 tháng 3 năm 2021, Bitcoin đã bứt phá lên trên một cái nêm giảm dần và đã tăng lên kể từ đó. Cho đến nay, BTC đã đạt mức cao cục bộ là $ 50.200 trước khi giảm nhẹ.</p><p>MACD và RSI đều tăng. Trong đó, MACD rất gần với việc vượt lên vùng dương và RSI đã di chuyển lên trên đường 50.</p><p>Vùng kháng cự chính được tìm thấy trong khoảng từ $ 50.659- $ 52.485. Một sự bứt phá lên trên phạm vi này sẽ xác nhận rằng xu hướng là tăng.</p><p><a href='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP1.png'><img src='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP1.png' alt='BTC-ETH-XRP' wh='672,342,672'></a></p><p>Biểu đồ BTC/USD khung 6 giờ | Nguồn: TradingView</p><p><strong>Ethereum (ETH)</strong></p><p>Tương tự như BTC, ETH đã bứt phá lên trên đường kháng cự giảm dần ngắn hạn vào ngày 1 tháng 3 và đã tăng lên kể từ đó.</p><p>Sự bứt phá diễn ra trước sự phân kỳ tăng đáng kể trong cả RSI và MACD.</p><p>Tuy nhiên, ETH vẫn chưa đạt đến vùng kháng cự chính được tìm thấy giữa các mức FIb thoái lui 0,5-0,618 tại $ 1.600- $ 1.750.</p><p>Cho đến khi ETH bứt phá lên trên khu vực này và xác nhận nó là hỗ trợ, chúng ta không thể coi xu hướng ngắn hạn là tăng.</p><p><a href='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP2.png'><img src='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP2.png' alt='BTC-ETH-XRP' wh='672,340,672'></a></p><p>Biểu đồ ETH/USD khung 6 giờ | Nguồn: TradingView</p><p><strong>XRP (XRP)</strong></p><p>XRP đã giảm kể từ khi bị từ chối bởi vùng kháng cự $ 0,63 vào ngày 22 tháng 2. XRP đã đạt mức cao thực tế là $ 0,65 nhưng đã tạo ra một bấc dài phía trên và đã giảm xuống kể từ đó.</p><p>Tại thời điểm viết bài, XRP đang tiếp cận vùng hỗ trợ $ 0,36.</p><p>Các chỉ báo kỹ thuật đang giảm, bằng chứng là chỉ báo Stochastic oscillator đã tạo ra một bearish cross và chỉ báo RSI giảm xuống dưới 50.</p><p><a href='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP3.png'><img src='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP3.png' alt='BTC-ETH-XRP' wh='672,338,672'></a></p><p>Biểu đồ XRP/USD hàng ngày | Nguồn: TradingView</p><p><strong>EOS (EOS)</strong></p><p>EOS đã giảm kể từ khi nó bị từ chối bởi vùng kháng cự dài hạn $ 5,50 vào ngày 14 tháng 2.</p><p>Mức giảm đã đưa nó xuống vùng $ 3,65, trước đây đóng vai trò là ngưỡng kháng cự và giờ đây dự kiến ​​sẽ đóng vai trò là hỗ trợ. Khu vực này cũng là mức Fib thoái lui 0,618 của động thái đi lên gần đây nhất.</p><p>Mặc dù đang ở mức hỗ trợ, EOS đã không thể bắt đầu một lần nảy. Hơn nữa, các chỉ báo kỹ thuật đang giảm và không xác nhận sự đảo chiều.</p><p><a href='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP4.png'><img src='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP4.png' alt='BTC-ETH-XRP' wh='672,343,672'></a></p><p>Biểu đồ EOS/USD hàng ngày | Nguồn: TradingView</p><p><strong>TRON (TRX)</strong></p><p>TRX đã giảm kể từ ngày 19 tháng 2, khi nó đạt mức cao cục bộ là $ 0,045. Mức giảm đã đưa nó xuống mức thấp cục bộ là $ 0,038 vào ngày 23 tháng 2.</p><p>Mặc dù mức giảm đáng kể, TRX đã tạo ra bấc dưới dài trong các khung thời gian cao và cố gắng giữ vững trên vùng $ 0,043.</p><p>Khu vực này trước đây đã đóng vai trò là vùng kháng cự trong hơn hai năm nhưng hiện đã được xác nhận là vùng hỗ trợ. Miễn là TRX được giao dịch trên mức này, xu hướng được coi là tăng.</p><p>Các chỉ báo kỹ thuật hỗ trợ kịch bản này. MACD, RSI và Stochastic Oscillator đều đang tăng.</p><p>Nếu TRX quản lý để xóa vùng kháng cự $ 0,065 (mức Fib thoái lui 0,618), thì ngưỡng kháng cự tiếp theo sẽ được tìm thấy ở mức $ 0,10.</p><p><a href='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP5.png'><img src='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP5.png' alt='BTC-ETH-XRP' wh='672,342,672'></a></p><p>Biểu đồ TRX/USD hàng tuần | Nguồn: TradingView</p><p><strong>Dash (DASH)</strong></p><p>DASH đã giảm kể từ khi đạt mức cao $ 365 vào ngày 19 tháng 2. Mức giảm đã đưa nó trở lại khu vực $ 185. Mức này đóng vai trò là ngưỡng kháng cự kể từ tháng 9 năm 2018 cho đến khi DASH cuối cùng bùng nổ vào đầu tháng 2 năm 2020.</p><p>Do đó, mức giảm hiện tại giống như một sự xác nhận mức này là hỗ trợ.</p><p>Miễn là DASH được giao dịch trên mức này, xu hướng được coi là tăng. Kịch bản này cũng được hỗ trợ bởi các chỉ báo kỹ thuật, bằng chứng là chỉ báo Stochastic Oscillator đã tạo ra một bullish cross.</p><p><a href='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP6.png'><img src='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP6.png' alt='BTC-ETH-XRP' wh='672,340,672'></a></p><p>Biểu đồ DASH/USD hàng tuần | Nguồn: TradingView</p><p><strong>Litecoin (LTC)</strong></p><p>LTC đã giảm kể từ khi đạt được mức cao nhất là $ 246 vào ngày 18 tháng 2. Mức giảm đã đưa nó xuống khu vực $ 170, trước đây hoạt động như một ngưỡng kháng cự. LTC đang trong quá trình xác nhận nó là hỗ trợ.</p><p>Chỉ báo MACD và Stochastic Oscillator đang tăng và có sự phân kỳ tăng ẩn trong chỉ báo RSI hàng tuần – một dấu hiệu mạnh mẽ của sự tiếp tục xu hướng.</p><p>Miễn là LTC được giao dịch trên mức này, nó dự kiến ​​sẽ tiếp tục tăng về phía mức cao trước đó ở $ 246 và có khả năng là vùng kháng cự ở mức cao nhất mọi thời đại là $ 315.</p><p><a href='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP7.png'><img src='https://tapchibitcoin.io/wp-content/uploads/2021/03/BTC-ETH-XRP7.png' alt='BTC-ETH-XRP' wh='672,337,672'></a></p><p>Biểu đồ LTC/USD hàng tuần | Nguồn: TradingView</p><p><strong>Disclaimer:</strong>&nbsp;Bài viết chỉ có mục đích thông tin, không phải lời khuyên đầu tư. Nhà đầu tư nên tìm hiểu kỹ trước khi ra quyết định. Chúng tôi không chịu trách nhiệm về các quyết định đầu tư của bạn.</p><ul><br></ul>",
                UserId = 2,
                Status = NewsStatus.Active,
                Type = NewsType.Gold,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.News.AddOrUpdate(new News()
            {
                Id = 5,
                Title = "Khối lượng DEX tháng 2 đạt mức ATH mới gần 73 tỷ đô la",
                Description = "Các sàn giao dịch phi tập trung (DEX) đã kết thúc tháng 2 với khối lượng hàng tháng cao nhất được ghi nhận, theo dữ liệu từ The Block.",
                Content = "<p>&nbsp;<span style='white-space: initial;'>Các sàn giao dịch phi tập trung (DEX) đã kết thúc tháng 2 với khối lượng hàng tháng cao nhất được ghi nhận, theo dữ liệu từ The Block.</span></p><p>Khối lượng hàng tháng của tháng Hai đạt mức cao mới xấp xỉ 72,89 tỷ đô la, tăng 12 tỷ đô la so với tháng 1.</p><p><img src='https://tapchibitcoin.io/wp-content/uploads/2021/03/dex.png' alt='' wh='672,380,672'></p><p>Uniswap tiếp tục dẫn đầu trong không gian DEX, chiếm phần lớn khối lượng hàng tháng với 36,6 tỷ đô la. Đây là tháng thứ ba liên tiếp của sàn giao dịch công bố khối lượng hàng tháng trên 30 tỷ đô la. SushiSwap và Curve đứng ở vị trí thứ hai, lần lượt đạt 14,93 tỷ USD và 4,42 tỷ USD.</p><p>Tháng 2 cũng có mức doanh thu hàng tháng cao nhất từ trước đến nay đối với các thợ đào Ethereum, khoảng một nửa trong số đó là phí giao dịch. Các con số doanh thu phản ánh giá ETH, đã vượt quá mốc $ 2000 trong một thời gian ngắn trong tháng này.</p>",
                UserId = 2,
                Status = NewsStatus.Active,
                Type = NewsType.Bronze,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.News.AddOrUpdate(new News()
            {
                Id = 6,
                Title = "Các nhà đầu tư chứng khoán khởi kiện MoneyGram vì các tuyên bố sai lệch liên quan đến XRP",
                Description = "Công ty thanh toán MoneyGram International đã bị kiện vì cáo buộc tuyên bố sai, được đưa ra liên quan đến quan hệ đối tác với Ripple Labs và tiền điện tử XRP của họ.",
                Content = "<p>Công ty thanh toán MoneyGram International đã bị kiện vì cáo buộc tuyên bố sai, được đưa ra liên quan đến quan hệ đối tác với Ripple Labs và tiền điện tử XRP của họ.</p><p><img src='https://tapchibitcoin.io/wp-content/uploads/2021/03/MoneyGram.jpg' alt='' wh='672,395,672'></p><p>Vụ kiện tập thể, được nộp vào ngày 1 tháng 3 tại California, đã được đệ trình thay mặt cho các nhà đầu tư đã mua chứng khoán từ MoneyGram trong khoảng thời gian từ ngày 17 tháng 6 năm 2019 đến ngày 22 tháng 2 năm 2021.</p><p>Cơ quan pháp lý về quyền của nhà đầu tư toàn cầu khẳng định MoneyGram đã đưa ra các tuyên bố gian dối liên quan đến quan hệ đối tác của họ với Ripple Labs và trạng thái của XRP như một chứng khoán.</p><p>Theo một bài đăng thông báo về “quan hệ đối tác chiến lược” giữa hai công ty vào tháng 6 năm 2019, MoneyGram đã sử dụng sản phẩm xRapid của Ripple, “tận dụng các khoản thanh toán XRP bằng ngoại hối” như một phần của quy trình thanh toán xuyên biên giới.</p><p>Tuy nhiên, vào ngày 23 tháng 12 năm 2020, công ty đã làm rõ rằng họ không phụ thuộc vào dịch vụ xRapid của Ripple cho các nhu cầu giao dịch ngoại hối của mình – dịch vụ này đã được đổi tên thành Thanh khoản theo yêu cầu (ODL) vào năm 2019:</p><p>“MoneyGram không sử dụng nền tảng ODL hoặc RippleNet để chuyển trực tiếp tiền của người tiêu dùng. Hơn nữa, MoneyGram không phải là một bên liên quan vụ kiện của SEC ”.</p><p>MoneyGram đã đình chỉ quan hệ đối tác với Ripple vào cuối tháng 2 sau khi Ủy ban Chứng khoán và Giao dịch Hoa Kỳ đệ đơn khiếu nại Ripple Labs với cáo buộc vi phạm chứng khoán vào tháng 12 năm 2020.</p><p>Các bị đơn cáo buộc rằng MoneyGram đã không tiết lộ rằng XRP đã bị SEC xem là một chứng khoán chưa đăng ký và bất hợp pháp.</p><p>Ngoài ra, trong trường hợp SEC quyết định thực thi luật chứng khoán chống lại Ripple, MoneyGram có thể sẽ mất đi dòng phí phát triển thị trường béo bở vốn rất quan trọng đối với kết quả tài chính của nó, họ nói thêm:</p><p>“Kết quả là, các tuyên bố công khai của bị cáo là sai lầm nghiêm trọng và / hoặc gây hiểu lầm vào các thời điểm có liên quan. Khi các chi tiết thực sự xâm nhập vào thị trường, vụ kiện cho thấy các nhà đầu tư là bên chịu thiệt hại”.</p><p>Ripple đã trả tiền cho MoneyGram để sử dụng nền tảng của mình trong khi cung cấp các động lực tài chính để giúp công ty khởi nghiệp mở rộng sang các thị trường mới.</p><p>Tờ&nbsp;Wall Street Journal&nbsp;đã báo cáo rằng MoneyGram đã nhận được 38 triệu đô la phí phát triển thị trường ròng từ Ripple vào năm 2020, chiếm khoảng 15% thu nhập đã điều chỉnh của công ty.</p><p>Thỏa thuận giữa hai công ty sẽ hết hạn vào năm 2023, với Ripple cũng đã đồng ý đầu tư lên tới 50 triệu đô la vào MoneyGram.</p>",
                UserId = 2,
                Status = NewsStatus.Active,
                Type = NewsType.Bronze,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.News.AddOrUpdate(new News()
            {
                Id = 7,
                Title = "Goldman Sachs mở lại quầy giao dịch tiền điện tử",
                Description = "Goldman Sachs sẽ mở lại bàn giao dịch tiền điện tử từ tuần tới, theo tin tức độc quyền từ Reuters.",
                Content = "<p>Goldman Sachs sẽ mở lại bàn giao dịch tiền điện tử từ tuần tới, theo&nbsp;<a href='https://www.reuters.com/article/crypto-currency-goldman-sachs/exclusive-goldman-sachs-restarts-cryptocurrency-desk-amid-bitcoin-boom-idUSL2N2KZ0XX'>tin tức</a>&nbsp;độc quyền từ Reuters.</p><p><img src='https://tapchibitcoin.io/wp-content/uploads/2021/03/Goldman-Sachs-Bitcoin-678x381-1.png' alt='bitcoin' wh='672,378,672'></p><p>Bàn giao dịch sẽ thuộc lĩnh vực tài sản kỹ thuật số của Goldman, bao gồm các dự án khác liên quan đến blockchain và tiền kỹ thuật số.</p><p>Ban đầu, Goldman sẽ cung cấp cho khách hàng hợp đồng tương lai Bitcoin và hợp đồng kì hạn không giao dịch (NDF). Ngân hàng cũng đang xem xét cung cấp các quỹ giao dịch Bitcoin qua sàn (ETF), cũng như khảo sát custody (lưu ký) tài sản kỹ thuật số.</p><p>Nhìn chung, lĩnh vực tài sản kỹ thuật số là một phần của bộ phận Thị trường toàn cầu của ngân hàng Hoa Kỳ.</p><p><strong>Mức độ quan tâm của giới tổ chức gia tăng</strong></p><p>Hoạt động mở cửa trở lại diễn ra trong bối cảnh các tổ chức ngày càng quan tâm nhiều hơn đối với BTC, vì giá của tiền điện tử hàng đầu đã tăng vọt 470% trong năm qua.</p><p>Một lý do mà các nhà đầu tư và một số công ty để mắt đến BTC là ngày càng có nhiều ý tưởng cho rằng nó có thể bảo vệ chống lạm phát đang gia tăng. Đặc biệt, điều này xuất hiện khi các chính phủ trên khắp thế giới đã chi hàng tỷ USD để kích thích nền kinh tế suy sụp do đại dịch Corona.</p><p>Bất chấp sự đồng thuận ngày càng tăng này, BTC vẫn rất biến động. Đó là lý do chính khiến các nhà đầu tư tổ chức do dự cho đến nay. Goldman hy vọng sẽ giảm thiểu rủi ro cho khách hàng của mình bằng cách cung cấp NDF, một loại công cụ phái sinh cho phép nhà đầu tư xem xét giá của tài sản trong tương lai.</p><p>Goldman lần đầu tiên mở quầy giao dịch tiền điện tử vào năm 2018. Tuy nhiên, vào thời điểm đó, giá BTC giảm từ mức cao kỷ lục, làm mất đi phần lớn sự quan tâm từ thị trường chính thống. Năm ngoái, ngân hàng đầu tư đã báo cáo rằng BTC “không phải là một loại tài sản” và “không phải là khoản đầu tư phù hợp”.</p><p>Kể từ đó, một số tổ chức tài chính được thành lập, chẳng hạn như CME Group. Intercontinental Exchange và Fidelity Investments đã chấp nhận tiền điện tử vì cơ sở hạ tầng thị trường cho chúng được phát triển hợp pháp.</p><p><strong>Bitcoin</strong><strong>&nbsp;ở ‘</strong><strong>đ</strong><strong>iểm&nbsp;</strong><strong>bùng phát’</strong></p><p>Như đã&nbsp;<a href='https://tapchibitcoin.io/citibank-dua-ra-truong-hop-tang-gia-cho-bitcoin-nhung-cung-canh-bao-ve-rui-ro.html'>đưa tin</a>, ngân hàng Citi mới tuyên bố rằng BTC đã ở “điểm bùng phát”. Vì ngày càng được nhiều công ty như Tesla chấp nhận, BTC có thể đang tiến tới một “sự chuyển đổi lớn” thành xu hướng chính thống. Mặt khác, báo cáo cảnh báo về khả năng “bùng nổ đầu cơ”.</p><p>Theo báo cáo của Citi, việc áp dụng BTC trên quy mô rộng sẽ phụ thuộc vào sự chấp nhận của nền tài chính chính thống đối với các loại tiền kỹ thuật số và ví. Việc Goldman tái thiết lập bàn giao dịch tiền điện tử của mình có ý nghĩa tốt cho kết quả này.</p>",
                UserId = 2,
                Status = NewsStatus.Active,
                Type = NewsType.Bronze,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.News.AddOrUpdate(new News()
            {
                Id = 8,
                Title = "Tòa án Tây Ban Nha ra lệnh điều tra về khả năng có “gian lận máy tính” trên sàn giao dịch Bittrex sau khi người dùng mất 1.3 BTC",
                Description = "Tòa án Tây Ban Nha đã ban hành lệnh buộc một bộ phận trong cảnh sát tại quốc gia này điều tra sự tồn tại có thể có về vấn đề “gian lận máy tính” trên nền tảng tiền điện tử Bittrex. Lệnh được đưa ra sau khi người dùng Bittrex có trụ sở tại Tenerife nộp đơn khiếu nại, người này tuyên bố đã mất 1.3 BTC (tương đương với khoảng 58,000 đô la) được lưu trữ trên sàn giao dịch.",
                Content = "<p>Tòa án Tây Ban Nha đã ban hành lệnh buộc một bộ phận trong cảnh sát tại quốc gia này điều tra sự tồn tại có thể có về vấn đề “gian lận máy tính” trên&nbsp;<a href='https://www.tapchibitcoin.io/bittrex-la-gi-tim-hieu-ve-san-giao-dich-bittrex.html'>nền tảng tiền điện tử Bittrex</a>. Lệnh được đưa ra sau khi người dùng Bittrex có trụ sở tại Tenerife nộp đơn khiếu nại, người này tuyên bố đã mất 1.3 BTC (tương đương với khoảng 58,000 đô la) được lưu trữ trên sàn giao dịch.</p><p><strong>Tội phạm mạng bị đổ lỗi</strong></p><p>Theo&nbsp;<a href='https://www.laprovincia.es/sucesos/2021/02/23/canario-denuncia-robo-80-000-35339050.html'>báo cáo</a>&nbsp;của phương tiện truyền thông Tây Ban Nha, vấn đề của người dùng giấu tên bắt đầu khi những nỗ lực để truy cập ban đầu vào tiền của anh ta không thành công. Tuy nhiên, sau khi có được quyền truy cập khoảng 48 giờ sau, người dùng báo cáo rằng “số Bitcoin của anh ta đã biến mất”. Người dùng đã liên hệ với đại diện của Bittrex, những người sau đó “cho rằng vụ trộm là do hành động của tội phạm mạng”.</p><p>Trong khi đó, theo lệnh ngày 9 tháng 2, Tòa án Tây Ban Nha cho biết họ muốn cơ quan thực thi pháp luật thực hiện “một dây chuyền nghiên cứu công nghệ, cho phép xác định chủ mưu của hành vi trộm cắp”. Tòa án cũng muốn công ty bảo hiểm của Bittrex tham gia vào cuộc điều tra cũng như cung cấp chính sách bảo hiểm thích hợp.</p><p><strong>Bittrex bị cáo buộc là có thể bị lừa</strong></p><p>Trong khi đó, báo cáo cũng trích dẫn một “chuyên gia” giấu tên, người đã liệt kê và giải thích các khoản phí có thể xảy ra mà Bittrex phải đối mặt do người dùng bị thiệt hại. Khi đổ lỗi cho hành vi trộm cắp trên sàn Bittrex, chuyên gia cho biết:</p><p>“Bittrex đã cho phép 4 lần truy cập trước vụ trộm, vào ngày 26 tháng 5 năm 2020, từ các địa chỉ IP khác nhau, vị trí khác nhau và hệ điều hành khác nhau, tất cả đều không phù hợp với những gì người dùng đã sử dụng cho đến thời điểm đó và Bittrex không làm gì để ngăn chặn điều đó”.</p><p>Theo chuyên gia, những sự kiện này xảy ra vào 3 ngày khác nhau từ Pháp, Granada, Madrid và một thị trấn ở Minnesota, Hoa Kỳ”.</p><p>Trong khi đó, chuyên gia cũng lưu ý rằng, các tội phạm mạng đã “bị cáo buộc sử dụng một hệ điều hành khác với hệ điều hành của chủ sở hữu tài khoản”. Điều này theo chuyên gia “lẽ ra nên đưa ra một báo động đỏ về vấn đề bảo mật cho Bittrex”.</p>",
                UserId = 2,
                Status = NewsStatus.Active,
                Type = NewsType.Gold,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.News.AddOrUpdate(new News()
            {
                Id = 9,
                Title = "Các ngân hàng Ấn Độ ‘soi’ tài khoản của trader tiền điện tử",
                Description = "Theo tin tức địa phương, các nhà đầu tư và trader là những nạn nhân mới nhất trong xu hướng ngày càng phổ biến rằng tổ chức hoạt động ngân hàng toàn cầu đóng tài khoản cá nhân. Quốc hội Ấn Độ hiện đang xem xét lệnh cấm tiền điện tử trên toàn quốc mà các nhà phê bình trong ngành tại địa phương chẳng hạn như cựu CTO Balaji Srinivasan của Coinbase đã so sánh với việc “cấm Internet trong 5 năm”.",
                Content = "<p>Theo&nbsp;<a href='https://economictimes.indiatimes.com/markets/stocks/news/after-taxman-banks-ring-warning-signals-for-customers-investing-trading-in-cryptocurrency/articleshow/81083303.cms'>tin tức</a>&nbsp;địa phương, các nhà đầu tư và trader là những nạn nhân mới nhất trong xu hướng ngày càng phổ biến rằng tổ chức hoạt động ngân hàng toàn cầu đóng tài khoản cá nhân. Quốc hội Ấn Độ hiện đang xem xét lệnh cấm tiền điện tử trên toàn quốc mà các nhà phê bình trong ngành tại địa phương chẳng hạn như cựu CTO Balaji Srinivasan của Coinbase đã&nbsp;<a href='https://www.the-captable.com/banning-crypto-tn-dollar-mistake'>so sánh</a>&nbsp;với việc “cấm Internet trong 5 năm”.</p><p><img src='https://tapchibitcoin.io/wp-content/uploads/2021/02/An-Do.png' alt='Ấn Độ' wh='672,519,672'></p><p>Economic Times báo cáo rằng khách hàng của các ngân hàng tư nhân ở Ấn Độ, chẳng hạn như HDFC, HSBC và Citi đã nhận được thông báo trong năm nay yêu cầu làm rõ giao dịch liên quan đến tiền điện tử, thường yêu cầu họ đến trực tiếp chi nhánh ngân hàng địa phương. Nếu không nhận được thông tin làm rõ như vậy, các tài khoản có nguy cơ bị đình chỉ hoặc bị thu giữ. Một lá thư gửi cho khách hàng nêu rõ:</p><p>“Để tuân thủ hướng dẫn quy định, các ngân hàng nên thực hiện trách nhiệm giải trình bằng cách kiểm tra chặt chẽ, liên tục giao dịch được thực hiện trong tài khoản để cảnh báo người dùng, chủ sở hữu và người giao dịch tiền ảo bao gồm cả Bitcoin về rủi ro”.</p><p>Vào năm 2020, Tòa án tối cao của Ấn Độ đã đảo ngược lệnh từ Ngân hàng Dự trữ Ấn Độ, trong đó các ngân hàng được yêu cầu ngừng cung cấp dịch vụ cho các trader.</p><p>Một người dùng Twitter&nbsp;<a href='https://twitter.com/karthikkonaar95/status/1362245289868861440'>phát biểu</a>:</p><p>“Cấm Bitcoin sẽ là một bước lùi cho Ấn Độ trong cộng đồng quốc tế. Tôi hy vọng các nhà lãnh đạo sẽ thực hiện các bước tích cực để đảm bảo điều chỉnh không gian tiền điện tử ở Ấn Độ. Đừng cấm, làm ơn hãy quy định”.</p><p>Quốc hội Ấn Độ dự kiến ​​sẽ ban hành một dự luật mới hạn chế hơn nữa các hoạt động tài chính của các trader và các thành viên nổi tiếng của cộng đồng tiền điện tử Ấn Độ đã lên tiếng phản đối. Sathvik Vishwanath, Giám đốc điều hành của sàn giao dịch Unocoin có trụ sở tại Ấn Độ,&nbsp;<a href='https://economictimes.indiatimes.com/markets/stocks/news/is-india-about-to-miss-the-bus-in-leveraging-cryptocurrency/articleshow/81107495.cms'>tin</a>&nbsp;rằng cần phải có một động thái ngược lại để khuyến khích sự phát triển của không gian fintech ở quốc gia của mình.</p><p>“Với tiền điện tử ở bên cạnh, đất nước có thể có lượng lớn dân số không có tài khoản ngân hàng”.</p><p>Các ngân hàng cũng đang đóng trước các tài khoản khách hàng được coi là có liên quan đến việc chuyển tiền vào hoặc ra khỏi các sàn giao dịch tiền điện tử ở một số quốc gia.</p><p>Vào ngày 5/2, Ngân hàng Trung ương Nigeria đã cấm các tổ chức tài chính hoạt động trong nước “tạo điều kiện thanh toán cho các sàn giao dịch tiền điện tử”, dẫn đến việc đóng cửa ngay lập tức các tài khoản ngân hàng liên kết với các sàn và cá nhân đứng sau chúng.</p><p>“Họ đã đóng 5 tài khoản ngân hàng vì tôi mua tiền điện tử … Tôi hiện không có tài khoản ngân hàng nào ngoại trừ ví sổ cái của mình … Tôi đoán bây giờ tôi là ngân hàng của chính mình”, một người dùng&nbsp;<a href='https://twitter.com/BashueBanks/status/1357682746106249221'>cho biết</a>.</p><p>Tại Vương quốc Anh,&nbsp;<a href='https://www.thetimes.co.uk/article/bitcoin-holders-barred-from-depositing-profits-in-uk-banks-pgswbfrdz'>HSBC</a>&nbsp;gần đây đã ngừng nhận chuyển khoản từ các sàn giao dịch tiền điện tử. Lloyds Bank, một ngân hàng thương mại và bán lẻ của Anh, cũng đang tăng cường nỗ lực tách bạch với các trader, theo podcaster Peter McCormack trong một&nbsp;<a href='https://twitter.com/PeterMcCormack/status/1363898264878211072'>tweet</a>&nbsp;ngày 22/2. Tuy nhiên, đó có thể là ‘tự lấy đá đập vào chân mình’.</p><p>Một nhà đầu tư Bitcoin lâu năm giấu tên sống tại Vương quốc Anh bình luận rằng các ngân hàng lớn trên khắp châu Âu đang ngày càng xa rời trader tiền điện tử. Các tài khoản mới đang bị các ngân hàng từ chối vì họ liên quan đến crypto.</p><p>“Tôi đang tìm cách tiếp cận cởi mở với một ngân hàng mới và hiểu rõ hơn về nó. Nhưng tôi đã gặp một bức tường chắn”. Nhà đầu tư tuyên bố đã đưa “sáu con số” thông qua HSBC và “không có vấn đề gì”, nhưng các tài khoản kế thừa đang được đối xử khác với những tài khoản mới.</p><p>“Nếu bạn không nói với họ và bạn đã tham gia, nó có vẻ ổn. Nhưng nếu bạn hỏi, câu trả lời là không”.</p>",
                UserId = 2,
                Status = NewsStatus.Active,
                Type = NewsType.Silver,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.SaveChanges();
            //// Currency_________________________________
            context.Currencies.AddOrUpdate(new Currency()
            {
                Id = 1,
                Name = "Bitcoin",
                Symbol = "BTC",
                ReleaseDate = "tháng 1 năm 2009",
                Description = "<p>Bitcoin là loại tiền mã hóa phi tập trung ban đầu được mô tả trong&nbsp;<a href='https://coinmarketcap.com/alexandria/glossary/whitepaper'>sách trắng</a>&nbsp;năm 2008 bởi một người hoặc một nhóm người, sử dụng bí danh&nbsp;<a href='https://coinmarketcap.com/alexandria/article/who-is-satoshi-nakamoto'>Satoshi Nakamoto</a>. Bitcoin đã ra mắt ngay sau đó vào tháng 1 năm 2009.</p><p>Bitcoin là một loại tiền tệ trực tuyến ngang hàng, nghĩa là tất cả các&nbsp;<a href='https://coinmarketcap.com/alexandria/article/how-long-does-a-bitcoin-transaction-take'>giao dịch</a>&nbsp;xảy ra trực tiếp giữa những người tham gia mạng lưới bình đẳng, độc lập mà không cần bất kỳ trung gian nào cho phép hoặc tạo điều kiện cho họ. Theo Nakamoto, Bitcoin được tạo ra để cho phép “thanh toán trực tuyến được gửi trực tiếp từ bên này sang bên khác mà không cần thông qua một tổ chức tài chính”.</p><p>Đã có những khái niệm cho một loại tiền mã hóa phi tập trung tương tự tồn tại trước BTC, nhưng Bitcoin có sự khác biệt là tiền mã hóa đầu tiên được sử dụng trên thực tế.</p>",
                Website = "https://bitcoin.org/",
                Status = CurrencyStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.Currencies.AddOrUpdate(new Currency()
            {
                Id = 2,
                Name = "Ethereum",
                Symbol = "ETH",
                ReleaseDate = "ngày 30 tháng 7 năm 2015",
                Description = "<p>Ethereum là một hệ thống&nbsp;<a href='https://coinmarketcap.com/alexandria/glossary/blockchain'>blockchain</a>&nbsp;mã nguồn mở phi tập trung có đồng tiền mã hóa riêng là Ether. ETH hoạt động như một nền tảng của nhiều loại&nbsp;<a href='https://coinmarketcap.com/alexandria/article/what-are-cryptocurrencies'>tiền mã hóa</a>&nbsp;khác, cũng như để thực hiện&nbsp;<a href='https://coinmarketcap.com/alexandria/glossary/smart-contract'>hợp đồng thông minh</a>&nbsp;phi tập trung.</p><p>Ethereum lần đầu tiên được mô tả trong sách trắng năm 2013 bởi Vitalik Buterin. Buterin, cùng với những người đồng sáng lập khác, đã bảo lãnh khoản tiền cho dự án trong đợt chào bán lần đầu ra công chúng vào mùa hè năm 2014 và chính thức ra mắt blockchain vào ngày 30 tháng 7 năm 2015.</p><p>Mục tiêu riêng của Ethereum là trở thành một nền tảng toàn cầu cho các ứng dụng phi tập trung, cho phép người dùng từ khắp nơi trên thế giới viết và chạy phần mềm có khả năng chống kiểm duyệt, thời gian chết và gian lận.</p>",
                Website = "https://www.ethereum.org/",
                Status = CurrencyStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.Currencies.AddOrUpdate(new Currency()
            {
                Id = 3,
                Name = "Binance Coin",
                Symbol = "BNB",
                ReleaseDate = "tháng 4 năm 2019",
                Description = "<p>BNB đã ra mắt thông qua đợt chào bán đồng tiền mã hóa lần đầu vào năm 2017, 11 ngày trước khi sàn giao dịch tiền mã hóa Binance ra mắt. Ban đầu, BNB được phát hành dưới dạng token ERC-20 chạy trên mạng Ethereum, với tổng nguồn cung tối đa là 200 triệu đồng coin và 100 triệu BNB được cung cấp trong ICO. Tuy nhiên, đồng coin ERC-20 BNB đã được hoán đổi với BEP2 BNB theo tỷ lệ 1:1 vào tháng 4 năm 2019 với sự ra mắt của mạng chính thức Binance Chain và hiện không còn được lưu trữ trên Ethereum nữa.</p><p>BNB có thể được sử dụng như một phương thức thanh toán, một token tiện ích để thanh toán phí trên sàn giao dịch Binance và để tham gia vào việc bán token trên Binance launchpad. BNB cũng cấp quyền cho Binance DEX (sàn giao dịch phi tập trung).</p>",
                Website = "https://www.binance.com/",
                Status = CurrencyStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.Currencies.AddOrUpdate(new Currency()
            {
                Id = 4,
                Name = "Cardano",
                Symbol = "ADA",
                ReleaseDate = "năm 2017",
                Description = "<p>Cardano là nền tảng blockchain&nbsp;<a href='https://coinmarketcap.com/alexandria/article/proof-of-work-vs-proof-of-stake'>bằng chứng cổ phần</a>&nbsp;cho biết mục tiêu của mình là cho phép “những người thay đổi, những người đổi mới và những người có tầm nhìn xa” mang lại sự thay đổi tích cực trên toàn cầu.</p><p>Dự án nguồn mở này cũng hướng tới việc “phân bổ lại quyền lực từ các cấu trúc không chịu trách nhiệm cho tới biên cho các cá nhân” — giúp tạo ra xã hội an toàn, minh bạch và công bằng hơn.</p><p>Cardano được thành lập vào năm 2017 và token ADA được thiết kế để đảm bảo rằng chủ sở hữu có thể tham gia vào việc vận hành mạng. Vì lý do này, những người nắm giữ tiền mã hóa có quyền bình chọn mọi đề xuất thay đổi phần mềm.</p><p>Nhóm nghiên cứu tạo ra blockchain phân lớp này cho biết đã có một số trường hợp sử dụng công nghệ của họ theo cách đầy thú vị. Mục đích của nhóm là cho phép các ứng dụng phi tập trung và hợp đồng thông minh phát triển theo mô-đun.</p><p>Cardano được các công ty nông nghiệp sử dụng để theo dõi sản phẩm tươi sống từ cánh đồng đến tận bàn ăn, trong khi các sản phẩm khác được xây dựng trên nền tảng này cho phép lưu trữ thông tin xác thực về giáo dục để chống giả mạo và các nhà bán lẻ ngăn chặn hàng giả.</p>",
                Website = "https://www.cardano.org/",
                Status = CurrencyStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.Currencies.AddOrUpdate(new Currency()
            {
                Id = 5,
                Name = "Polkadot",
                Symbol = "DOT",
                ReleaseDate = "",
                Description = "<p>Polkadot là giao thức đa chuỗi phân mảnh mã nguồn mở hỗ trợ việc chuyển chéo chuỗi bất kỳ loại dữ liệu hoặc tài sản nào, không chỉ token. Bằng cách đó, một loạt blockchain có thể tương tác với nhau.</p><p>Cơ chế tương tác này tìm cách thiết lập một web hoàn toàn phi tập trung và riêng tư do người dùng kiểm soát và đơn giản hóa quy trình tạo các ứng dụng, tổ chức và dịch vụ mới.</p><p>Giao thức Polkadot kết nối các chuỗi công cộng và riêng tư, mạng không cần cấp phép, oracle và các công nghệ tương lai, cho phép các blockchain độc lập này chia sẻ thông tin và giao dịch một cách theo cách phi tín nhiệm thông qua chuỗi chuyển tiếp Polkadot (giải thích thêm ở phần dưới).</p><p>Token gốc của Polkadot là DOT phục vụ ba mục đích rõ ràng: cung cấp chức năng hoạt động và quản trị mạng, đồng thời tạo các parachain (chuỗi song song) bằng cách liên kết.</p><p>Polkadot có bốn thành phần cốt lõi:</p><ul><li>Chuỗi chuyển tiếp: “trái tim” của Polkadot, giúp tạo ra đồng thuận, khả năng tương tác và bảo mật được chia sẻ trên mạng của các chuỗi khác nhau;</li><li>Parachain: các chuỗi độc lập có thể có token riêng và được tối ưu hóa cho các trường hợp sử dụng cụ thể;</li><li>Parathread: tương tự như parachain nhưng có khả năng kết nối linh hoạt dựa trên mô hình dùng đến đâu trả tiền đến đó;</li><li>Cầu nối: cho phép các parachain và parathread kết nối và giao tiếp với các blockchain bên ngoài như Ethereum.</li></ul>",
                Website = "https://polkadot.network/",
                Status = CurrencyStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.Currencies.AddOrUpdate(new Currency()
            {
                Id = 6,
                Name = "XRP",
                Symbol = "XRP",
                ReleaseDate = "năm 2012",
                Description = "<p>Để bắt đầu, bạn cần phải hiểu sự khác biệt giữa XRP, Ripple và RippleNet. XRP là đồng tiền chạy trên nền tảng thanh toán kỹ thuật số gọi là RippleNet, nằm trên cơ sở dữ liệu sổ cái phân tán được gọi là XRP Ledger. Còn RippleNet được điều hành bởi một công ty có tên là Ripple, XRP Ledger là nguồn mở và không dựa trên blockchain, mà là cơ sở dữ liệu sổ cái phân tán đã đề cập trước đây.</p><p>Nền tảng thanh toán RippleNet là hệ thống thanh toán gộp theo thời gian thực (RTGS) nhằm mục đích cho phép các giao dịch tiền tệ tức thì trên toàn cầu. Mặc dù XRP là tiền mã hóa có nguồn gốc từ XRP Ledger, nhưng bạn thực sự có thể sử dụng bất kỳ loại tiền tệ nào để giao dịch trên nền tảng này.</p><p>Mặc dù ý tưởng đằng sau nền tảng thanh toán Ripple lần đầu tiên được Ryan Fugger công bố vào năm 2004, nhưng phải đến khi Jed McCaleb và Chris Larson tiếp quản dự án vào năm 2012 thì Ripple mới bắt đầu được xây dựng (tại thời điểm đó, nó còn được gọi là OpenCoin).</p>",
                Website = "https://ripple.com/xrp/",
                Status = CurrencyStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.Currencies.AddOrUpdate(new Currency()
            {
                Id = 7,
                Name = "Enjin Coin",
                Symbol = "ENJ",
                ReleaseDate = "tháng 7 năm 2017",
                Description = "<p>Enjin Coin là một dự án của Enjin, một công ty cung cấp một hệ sinh thái gồm&nbsp;các sản phẩm trò chơi dựa trên&nbsp;<a href='https://coinmarketcap.com/alexandria/glossary/blockchain'>blockchain</a>&nbsp;, được kết nối với nhau&nbsp;.&nbsp;Sản phẩm hàng đầu của Enjin là Enjin Network, một nền tảng trò chơi xã hội mà qua đó người dùng có thể tạo các trang web và gia tộc, trò chuyện và lưu trữ các cửa hàng vật phẩm ảo.</p><p>Enjin cho phép các nhà phát triển trò chơi mã hóa các vật phẩm trong trò chơi trên chuỗi khối&nbsp;<a href='https://coinmarketcap.com/currencies/ethereum/'>Ethereum</a>&nbsp;.&nbsp;Nó sử dụng Enjin Coin, một&nbsp;mã thông báo&nbsp;<a href='https://coinmarketcap.com/alexandria/glossary/erc-20'>ERC-20</a>&nbsp;, để hỗ trợ các tài sản kỹ thuật số được phát hành bằng nền tảng của nó, có nghĩa là các mặt hàng có thể được mua, bán và giao dịch với giá trị trong thế giới thực.</p><p>Enjin Coin được&nbsp;<a href='https://blog.enjin.io/announcing-enjin-coin/'>công bố</a>&nbsp;lần đầu tiên&nbsp;vào tháng 7 năm 2017 và nó&nbsp;<a href='https://blog.enjin.io/enjin-coin-smart-contracts-live-on-mainnet/'>đã ra mắt</a>&nbsp;trên mạng chính Ethereum vào tháng 6 năm 2018.</p>",
                Website = "https://enjin.io/",
                Status = CurrencyStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.Currencies.AddOrUpdate(new Currency()
            {
                Id = 8,
                Name = "Stellar",
                Symbol = "XLM",
                ReleaseDate = "tháng 7 năm 2014",
                Description = "<p>Nói một cách đơn giản, Stellar là một mạng mở cho phép di chuyển và lưu trữ tiền. Khi được phát hành vào tháng 7 năm 2014, một trong những mục tiêu của Stellar là thúc đẩy tài chính toàn diện thông qua việc tiếp cận nhóm người không sử dụng dịch vụ ngân hàng trên thế giới — nhưng ngay sau đó, ưu tiên của Stellar đã chuyển sang việc giúp các công ty tài chính kết nối với nhau thông qua công nghệ blockchain.</p><p>Token gốc của mạng, lumens, đóng vai trò như cầu nối giúp giao dịch tài sản xuyên biên giới ít tốn kém hơn. Tất cả điều này nhằm mục đích thách thức các nhà cung cấp dịch vụ thanh toán hiện tại, vốn thường tính phí cao cho dịch vụ tương tự.</p><p>Nếu tất cả những điều này nghe có vẻ quen thuộc thì cần lưu ý rằng Stellar ban đầu dựa trên giao thức Ripple Labs. Blockchain được tạo ra là kết quả của phân tách cứng và mã sau đó đã được viết lại.</p>",
                Website = "https://www.stellar.org/",
                Status = CurrencyStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.Currencies.AddOrUpdate(new Currency()
            {
                Id = 9,
                Name = "Dogecoin",
                Symbol = "DOGE",
                ReleaseDate = "tháng 12 năm 2013",
                Description = "<p>Dogecoin (DOGE) dựa trên hình chế 'doge' nổi tiếng trên mạng Internet với hình chú chó Shiba Inu trên logo. Đồng tiền kỹ thuật số nguồn mở này được tạo ra bởi Billy Markus đến từ thành phố Portland, tiểu bang Oregon và Jackson Palmer đến từ thành phố Sydney, Úc. Dogecoin được phân tách từ Litecoin vào tháng 12 năm 2013. Những người tạo ra Dogecoin dự tính đồng tiền này sẽ là đồng tiền mã hóa thú vị, vui nhộn, có sức hấp dẫn hơn cả đồng Bitcoin cốt lõi, vì Dogecoin dựa trên hình chế một chú chó. Giám đốc điều hành Tesla là Elon Musk đã đăng một số dòng tweet trên mạng xã hội rằng Dogecoin là đồng coin yêu thích của ông.</ p>",
                Website = "http://dogecoin.com/",
                Status = CurrencyStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-5, -1)),
            });
            context.SaveChanges();
            //base.Seed(context);
        }
    }
}
