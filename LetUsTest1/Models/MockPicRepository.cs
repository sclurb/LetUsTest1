using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsTest1.Models
{

    
    public class MockPicRepository : IPicsRepository
    {
        private List<Pics> _pics;
        public MockPicRepository()
        {
            if(_pics == null)
            {
                InitializePics();
            }
        }


        private void InitializePics()
        {
            _pics = new List<Pics>
            {
                new Pics {Id = 1, Name = "Dubai PoolSide", Description = "Hangin By The Pool Away from Afghanistan", LongDescription = "I was finally out of the desert mess in KAF and I was astonished to be in a place where I could actually have a beer and relax.  The pressure of living under a military authority was over after a tense time.   God it felt great.   It was a victory for sure.", ImageUrl = "\\pics\\10-11-09Out001.jpg" },
                new Pics {Id = 2, Name = "Check Point Charlie", Description= "Visiting cousins in Berlin", LongDescription = "After leaving Dubai, I stopped in Frankfurt and took the train to Berlin to sort of adjust to normal life before coming home.   I visited my cousin Gundual Wichers and her man Kai, not to mention their young daughter Leoni.   It was nice to be around normal folks and not have to go to meetings with the military apparatus in KAF (Kandahar Air Field).   The big tens adventure was over for a little while.   BTW, anyone interested might want to know that none of the guys in the picture here were American.   They were not even German.   You had to pay in order for them to pose with you...UGH.", ImageUrl = "\\pics\\10-21-09_Germany046.jpg"},
                new Pics {Id = 3, Name = "Vase", Description = "Antique Wichers Vase", LongDescription = "Well they say Europe is the old country.   That vase I was told is a family hierloom from the 15th century.   My cousin Gundula Wichers proudly showed me this vase and I thank her!   I was instantly afraid that something woudl happen to it and it would be my fault.   I was quite impressed to say the least.   And now I am glad I am not responsible for it.   I am too rough around the edges to handle things of that sort.", ImageUrl = "\\pics\\10-21-09_Germany048.jpg"},
                new Pics {Id = 4, Name = "Palm Pavilion", Description = "Back home safe and sound", LongDescription = "It was good to be back home in the place I love so much.   My mother told me stories about how she used to go dancing at the Palm Pavilion back in the 1940's.   It was really good to come back and see that again.", ImageUrl = "\\pics\\10-21-09_Germany058.jpg"},
                new Pics {Id = 5, Name = "Aegina, Greece 2009", Description = "Taking a vacation in Europe", LongDescription = "After arriving to Qatar in October of 2008 and working in rough conditions until about April 2009, I took a vacation across Europe with my then girlfriend Melissa.   We statyed in Athens for a week and we took a day trip out to Aegina.   What a beautiful unspoiled place that was.", ImageUrl ="\\pics\\Athens_01_ 029.jpg"},
                new Pics {Id = 6, Name = "Bagram Air Base", Description = "Standing with soldiers and my luggage", LongDescription = "I have been trying to figure out why it is night time and I am standing with my luggage in Bagram.   I remember arriving in daylight hours and then leaving in daylight hours.   So why am I standing there with all my luggage at night?   I dunno.   The funny thing is I remember the picture being taken, but I still cannot remember why I was out there with my luggage.", ImageUrl = "\\pics\\12-16-09_Bagram016.jpg"},
                new Pics {Id = 7, Name = "Leaving US for Qater", Description = "I was embarking on a crazy journey", LongDescription = "Well this was an anxious time.   I knew I was leaving that night to Qater.   This picture was taken in South Carolina.   I was flying to Dulles airport in Virginia where I boarded a flight to Doha, Qatar.   It was the beginning of a trip that was way outside my comfort zone.   Of course I will say the obvious.   That would be that... 'I wish I doid not know now what I did not know then'  ...lol", ImageUrl = "\\pics\\1stnightqatar001.jpg"  },
                new Pics {Id = 8, Name = "Resort Abu Dhabi", Description = "Trying to enjoy a little time off", LongDescription = "From about mid May to late Jume, I was working in Abu Dhabi.   This was the most normal place I visited while in the middle east.   It might not look like it, but it was hot as hell.   I think about 125 degrees Fahrenheit in the shade with 100% humidity.   It was rediculously uncomfortabel.   Hard to describe and I live in Florida.   It really was a sort of resort...in hell!   lol", ImageUrl = "\\pics\\AbuDhabi009.jpg"},
                new Pics {Id = 9, Name = "Love Bug in Athens?", Description = "Just another hippie in Athens", LongDescription = "I thought all of that ended where it began back in the 60's?   Maybe not!   I guess this guy just had to be a hippie in Athens in April 2009.   It's a crazy world is it not?", ImageUrl = "\\pics\\Athens_02_ 022.jpg"},
                new Pics {Id = 10, Name = "Acropolis Hill", Description  = "The back side of the Acropolis" ,LongDescription = "This is sort of the back side of the hill the Acropolis sits on.   I used with my special digital zoom to get  close up of what we had been looking at every day in Athens as we walked through the market area of downtown.",ImageUrl = "\\pics\\Athens_02_ 025.jpg"},
                new Pics {Id = 11, Name = "Slime Pit", Description = "The big black pond of...CRAP", LongDescription = "If you have ever visited any of the bases the US has in the middle east, you will know what this is.   You see every base needs to have a sewage treatment plant.   It is probably due to operational security that they have these...'ponds'.. on base instead of farther away and out of smeel range.   With the desert heat, it really whpped up quite a stink for all to experience.   Sometimes...no more often than not, you could also smell it inside your living quarters.   Yum Yum.   That really added to the misery of being away from home.   ", ImageUrl = "\\pics\\Kandahar001.jpg"},
                new Pics {Id = 12, Name = "Desert Hockey", Description = "Hockey Games to Entertain the Troops", LongDescription = "I was entertained (OK, I was starved for entertainment) with watching Canadian and Slovak troops playing intense hockey games at night on concrete instead of ice.   These guys were into it too.   There were a few fights, but in the end, the Slovaks seemed to dominate every time.   I though it was Canadians who played good hockey?", ImageUrl = "\\pics\\Kandahar008.jpg"},
                new Pics {Id = 13, Name = "ASI at KAF", Description = "Just finishing a partially successful repair", LongDescription = "This is why I was in Kandahar.   Because of my background and the fact that I had worked for the company who manufactured this mobile satellite transmitter, I was there straightening out what had become a fiasco for several diiferent reasons.   This shelter was never intended to be in a desert climate.   The airconditioning was failing daily.   It also had some issues with the feed horn which is why we were up in the dish taking look.   The other two gentlemen were from General Dynamics and Rockwell Collins.   I was working for DRS.   I was actually pretty frustrated at that point.   I had argued for an Authorized Service Interruption in order to make a few repairs.   We got most of it, but there wre still outstsanding issues.   Those outstanding issues meant that I would be staying there longer...Yuk!", ImageUrl = "\\pics\\Kandahar016.jpg"},
                new Pics {Id = 14, Name = "Barbecue at KAF", Description = "A Nice Day for a Barbeque at KAF", LongDescription = "Well I knew I was getting cole to the end.   Becuase of me success?????, I was asked/made to stay longer.   I for whatever stupid reason. to grow a beard...of sorts.  Well then I got really itchy in the face a bit just after this picture was taken.   Beard got shaved off before it amounted to much.   I like a bare face! ", ImageUrl = "\\pics\\KandaharNearEnd001.jpg"},
                new Pics {Id = 15, Name = "Hand Off!", Description = "Thought I would leave KAF", LongDescription = "Well in my mind, handing off the keys to this nightmare of a mobile uplink truck would be the end of my worries.   Our comnpany, DRS, handed the control and future of this project to another company.   To me it was good because this mess should have never happened in the first place.   After the major mistakes had been corrected as much as they could, professionals took over and got things to where they needed to be.   It was a very hard difficult process.   More often than not, it resembled  a circular firing squad.   I survived.", ImageUrl = "\\pics\\KandaharNearEnd036.jpg"},
                new Pics {Id = 16, Name = "Sat Dish Trouble", Description = "Helping some fellow contracters work on some broken dishes", LongDescription = "After getting aquainted with some of the other contractors, we became fast friends.   They had trouhble it was also my trouble and if I had trouble it was the same.   It really made things much easier for all of us.   We pulled together what we all know.", ImageUrl = "\\pics\\KandaharNight_tracers002.jpg"},
                new Pics {Id = 17, Name = "Bizarre Bazaar", Description = "I too some time to visit what was supposed to be a Bazaar.   It was more like a money trap for soldiers and or contractors.   I mean I do not want to bust on it too bad.   Because there were some really neat things worth buying for the novelty factor, but there was also some pretty bad rip-offs.   It was bizarre to be there.", ImageUrl = "\\pics\\KandaharNight_tracers002.jpg"},
                new Pics {Id = 18, Name = "Olympic Stadium", Description = "At the original.. stadium for the olypics back like a long time ago...   ", LongDescription = "While in Athens, who could pass up the opportunity to see the Olympic stadium where the games orinially started back in actient times.   I saw it and I got pictures.", ImageUrl = "\\pics\\LastDay018.jpg" },
                new Pics {Id = 19, Name = "A top the Acropolis!", Description = "On Top of the Hill", LongDescription = "This was after we walked all the way up that hill and stood through line after line.   I fianlly was on top of that hill looking down.   The long history of that place is pretty obvious and of course makes you think about how many people from fifferent parts of the world have been there and all through out time.", ImageUrl = "\\pics\\Melissa_Athens078.jpg"},
                new Pics {Id = 20, Name = "Turkey Kirkuk", Description = "During my stay we had Thanksgiving", LongDescription = "Wel it was not a great Thanksgiving, but it obviously could have been worse.", ImageUrl = "\\pics\\Thanksgiving002.jpg"}
            };

        }

        public IEnumerable<Pics> GetPics()
        {
            return _pics;
        }

        public Pics GetPicById(int picId)
        {
            return _pics.FirstOrDefault(p => p.Id == picId);
        }
    }
}
