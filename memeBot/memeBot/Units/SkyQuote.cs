using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace memeBot.Units
{
    public class SkyQuote : ModuleBase<SocketCommandContext>
    {
        [Command("sky")]
        public async Task SkyAsync()
        {
           
            string text = " ";
            string[] x =
            {
                "Luck is the stuff that we're too lazy to calculate",
                "Being greedy allows you to win in Game Theory. But everyone will think you're a jerk.",
                "Insanity is doing the same thing twice and expecting a different result. But if there is a different result, it's probably 'cause you're programming in Java.",
                "Plagiarism is copying work from one person. Research is copying work from many people. Kind of like this quote.",
                "The key to creativity is hiding your sources.",
                "The problem with this world is that the people who are qualified are too scared to take charge and the people in power are too stupid to realize their stupidity.",
                "Everything has an agenda. We usually can't see it.",
                "Question everything. You'll find that you can't prove anything.",
                "Professional re-inventor of the wheel here.",
                "Knowledge is power.",
                "History will be kind to me because I plan to overwrite it.",
                "There is no other way to play than all-out.",
                "On the outside, play nice with the System. On the inside, plan it's demise.",
                "Maybe I'll just do *this* to see what happens.",
                "What If? No. Why Not?",
                "The value of a life is based on its benefit of others.",
                "You never lose. Either you win or you learn.",
                "GOTTEM [in response to programming breakthrough]",
                "🔥🔥🔥 SATISFACTION 🔥🔥🔥",
                "100% of the people who make fake statistics tend to lie",
                "Those who do not examine history are doomed to repeat it. Those who do examine history repeat it anyways.",
                "Git is a life skill.",
                "But what does it *actually* mean?",
                "Always have another ace up your sleeve. You never know when you might need a replacement.",
                "More support generates more power, but more power degrades support.",
                "Power corrupts, and more power corrupts more.",
                "Communism would work, but humans are too garbage to cooperate.",
                "We need to go deeper.",
                "We might be in the matrix. But if we woke up, how would we know that there aren't any more matrices?",
                "Humans hate logic. If that statement is true, then that mean that this is a paradox?",
                "Q = mc(delta)MEME",
                "He who knows a little of everything knows nothing at all, but he who knows much of one thing knows society hates multitudes.",
                "Absolutely fixed relatively broken quotes.",
                "You're only wrong when you admit it. What's that? It's not true? Leave.",
                "Memes expire pretty quickly.",
                "Are you *sure* about that?",
                "***AHEM***",
                "If you want to go fast, go alone, but if you want to go far, go together.",
                "Innovation never happened by the group. Innovation always happened by the individual.",
                "You might have the best ideas in the world, but nobody will know if don't say something.",
                "In Asia, they call it arrogance, but in America ['Merica], it's called **pride**.",
                "Programming something is like running. You can see the end but the path seems to get longer the further you go.",
                "It was like I was fixing by chair and the whole house collapsed around me.",
                "Always forgive. But narrow your eyes everytime you do.",
                "I'll be saving that for blackmail-- I mean... storytelling.",
                "A bug? No. \nB*tch, it's a feature. [sunglasses commence]",
                "Money buys convenience. That's convenient.",
                "No reGERTS.",
                "Have fun.",
                "EXPOSED.",
                "Keep your breaks short. 'Cause if they get longer, you'll need breaks from your breaks.",
                "JUST DO IT. If you slow down, it's harder to speed up again.",
                "A person who dares waste an hour of time has not yet discovered the value of life.",
                "2 + 2 = 5",
                "Hit Confirmed",
                "The loveliest rose can hide the cruelest thorn.",
                "42",
                "Try integrating a teapot some time.",
                "Break a leg. That's some pretty stupid advice.",
                "Peoples is a real word",
                "Say something enough times and it becomes true.",
                "Never let you leave. Never let you rest.",
                "Conglatulations",
                "Make math your _____",
                "Have fun with that.",
                "How was it? It was fun. . . . . to watch people squirm",
                "Mutually Assured Destruction is bad.",
                "Is your life as bland as this text?",
                "9 + 10 = 21. Do a bunch of janky sig figs and that happens.",
                "More on that... later.",
                "Luck is just skill that you don't realize at the moment",
                "Magic is science we don't understand yet.",
                "Science is magic we don't understand yet.",
                "Pickle",
                "Alexa, play despacito https://www.youtube.com/watch?v=kJQP7kiw5Fk",
                "You may be alive, but there are different *forms* of alive.",
                "The Twilight Zone",
                "The light is at the end of the tunnel! Just a quick drop through the center of the earth to get to it on the other side!",
                "I do agree with your point, but the execution could be a bit better.",
                "Stupid Entropy!!!",
                "You can't handle the truth!",
                "Glory to the king, death to bad government.",
                "If men were angels we wouldn't need a government.",
                "I'm afraid I can't do that >:)",
                "Money is the root of all evil (but there are different *forms* of evil)",
                "Idle hands are the devil's playground",
                "The last 10% is 90% of the work.",
                "Stop token scraping!",
                "It's a trap!"
            };
            int index = new Random().Next(0, x.Length);
            text += "```" + x[index] + "\n -Sky```";
            
            await ReplyAsync(text);
        }
            
        
    }
}
