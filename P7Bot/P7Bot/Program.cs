using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace P7Bot
{
    class Program
    {
        private static string TOKEN { get; set; } = "7137210246:AAHJ2EJi9Z8gtVkUNRs-LnwN0G_oqWyVoZw";
        static void Main(string[] args)
        {
            var BotClient = new TelegramBotClient(TOKEN);
            BotClient.SetWebhookAsync(URL);
            BotClient.StartReceiving(Update,Error);
            Console.ReadLine();
        }

        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message.Text != null) 
            { 
                if (message.Text.ToLower().Contains("/start"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, $"Привет! Меня зовут Ли́са.\r\nРада с тобой познакомиться, {message.Chat.Username}. Я сделана для того, чтобы рассказывать тебе всякое.\r\nПосмотри, что я могу:\r\n/lessons - Узнай, что я могу тебе рассказать 📔; ...команда в разработке, извините :(\r\n/feedback - Напиши своё мнение обо мне 📒.\r\n/tell - Расскажи мне что-нибудь 📚.\r\nЗаранее извини если я буду работать плохо. Надеюсь, мы с тобой поладим.");
                    return;
                }
                if (message.Text.ToLower().Contains("/feedback"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Держи ссылочку!\r\nЗдесь ты можешь оставить отзыв о моей работе:\r\nhttps://forms.gle/e8vcwbxoj3EXaWrH8");
                    return;
                }
                if (message.Text.ToLower().Contains("/tell"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Держи ссылочку!\r\nЗдесь ты можешь рассказать мне что-то новое:\r\nhttps://forms.gle/AApbrVZPX37pPxfK6");
                    return;
                }
                if (message.Text.ToLower().Contains("/lessons"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Я немножечко знаю про:\r\n🎨 Рисование - painting\r\n🖌Писательство - writing\r\n🎸 Музыка - music\r\n🖥 Программирование - program\r\nЧтобы выбрать тему напиши кодовое слово (слово на английском после тире).\r\nБуду признательна, если ты поделишься со мной своими знаниями.");
                    return;
                }
                if (message.Text == "painting")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Вот что я могу тебе посоветовать в области рисования:\r\n\r\nАниме 👩\r\nhttps://youtu.be/3Y5RkHXfOGg?si=MXco95RRwXVws44Q\r\n\r\nЧиби ☺️\r\nhttps://youtu.be/r0E-vZuJnLg?si=erC5vFLr63qoTlMY\r\n\r\nМилота \U0001f970\r\nhttps://youtu.be/LQyCNArDNN0?si=H-R8S7y1V3-EyiQQ\r\n\r\nБуду благодарна, если поможешь найти мне больше информации :D");
                    return;
                }
                if (message.Text == "writing")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Вот что я могу тебе посоветовать в области писательства:\r\n\r\nСтихи ✍️\r\nhttps://youtu.be/cQ2e46DuP70?si=3J-f645aX_mXBNFD\r\n\r\nМне будет приятно, если ты поможешь мне найти больше информации :D");
                    return;
                }
                if (message.Text == "music")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Вот что я могу тебе посоветовать в области музыки:\r\n\r\nПесни 🎤\r\nhttps://youtu.be/0qMVGo2Gj2k?si=fDyqoSDv1UGIpmrb\r\n\r\nГитара 🎸\r\nhttps://youtu.be/w8eccjOeotQ?si=osV9rIsifYFxP9OS\r\n\r\nБуду благодарна тебе, если поможешь найти больше информации :D");
                    return;
                }
                if (message.Text == "program")
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Вот что я могу тебе посоветовать в области программирования:\r\n\r\nPython 🐍\r\nhttps://youtu.be/LFCq-mNF96c?si=Np95eDUe8rmna9oI\r\n\r\nЯ буду благодарна тебе, если ты поможешь мне найти больше информации :D");
                    return;
                }
            }
        }

        private static Task Error(ITelegramBotClient botClient, Exception exception, CancellationToken token) 
        {
            throw new NotImplementedException();
        }
    }
}