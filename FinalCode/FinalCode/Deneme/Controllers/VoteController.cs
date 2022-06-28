using Deneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deneme.Controllers
{
    public class VoteController : Controller
    {
        private GraduationProjectManagementDBEntities objRatingDbEntities;
        public VoteController()
        {
            objRatingDbEntities = new GraduationProjectManagementDBEntities();
        }
        // GET: Vote
        public ActionResult Index(int GroupID)
        {

            IEnumerable<VoteViewModel> listvoteViewModels = (from objVote in objRatingDbEntities.VoteTbl
                                                             where objVote.AssignGroup == GroupID
                                                             select new VoteViewModel()
                                                             {
                                                                 VoteID = objVote.VoteID,
                                                                 VoteDescription = objVote.VoteDescription,
                                                                 VoteDescription2 = objVote.VoteDescription2,
                                                                 VoteDescription3 = objVote.VoteDescription3,
                                                                 Rating = objVote.Rating,
                                                                 Rating2 = objVote.Rating2,
                                                                 Rating3 = objVote.Rating3,
                                                                 AssignGroup = objVote.AssignGroup,
                                                                 CommentedOn = objVote.CommentedOn




                                                             }).ToList();

            IEnumerable<QuestionViewModel> listQusetionViewModels = (from objQuestion in objRatingDbEntities.QuestionTbl
                                                                     select new QuestionViewModel()
                                                                     {
                                                                         QuestionDescription = objQuestion.QuestionDescription,
                                                                         QuestionID = objQuestion.QuestionID,
                                                                         QuestionSubject = objQuestion.QuestionSubject

                                                                     }).ToList();





            ViewBag.AssignGroup = GroupID;


            //ViewBag.QuestionID = QuestionID;
            return View(listQusetionViewModels);
        }


        public ActionResult MultipleData()
        {
            List<QuestionTbl> questionTbls = new List<QuestionTbl>();
            //var mymodel = new VoteViewModel();
            //mymodel.questionTbls = objRatingDbEntities.QuestionTbls.ToList();
            return View(questionTbls);
        }

        [Authorize(Roles = "Professor")]
        public ActionResult SelectGroup()
        {
            List<JuriesTbl> juriesTbls = objRatingDbEntities.JuriesTbl.ToList();
            List<GroupTbl> groupTbls = objRatingDbEntities.GroupTbl.ToList();
            List<ProjectTbl> projectTbls = objRatingDbEntities.ProjectTbl.ToList();
            List<VoteTbl> voteTbls = objRatingDbEntities.VoteTbl.ToList();
            List<GroupRatingResultTbl> groupRatingResultTbls = objRatingDbEntities.GroupRatingResultTbl.ToList();

            List<ProfessorTbl> professorTbls = objRatingDbEntities.ProfessorTbl.ToList();
            List<Jury_ProfessorTbl> jury_ProfessorTbls = objRatingDbEntities.Jury_ProfessorTbl.ToList();
            List<Jury_GroupTbl> jury_GroupTbls = objRatingDbEntities.Jury_GroupTbl.ToList();

            var multipletable = from pt in professorTbls
                                join jp in jury_ProfessorTbls on pt.ProfessorID equals jp.ProfessorID into table4
                                from jp in table4.DefaultIfEmpty()
                                join j in juriesTbls on jp.JuryID equals j.JuryID into table5
                                from j in table5.DefaultIfEmpty()
                                join jg in jury_GroupTbls on j.JuryID equals jg.JuryID into table6
                                from jg in table6.DefaultIfEmpty()
                                join g in groupTbls on jg.GroupID equals g.GroupID into table7
                                from g in table7.DefaultIfEmpty()





                                select new JuryGroupProject { juriesTbls = j, groupTbls = g, /*projectTbls = p, groupRatingResultTbls = va,*/ Proftbl = pt, Jury_ProfessorTbl = jp };

            return View(multipletable);
        }



        [Authorize(Roles = "Professor")]
        public ActionResult ShowGroup(int GroupID)
        {

            //List<QuestionTbl> questionTbls = objRatingDbEntities.QuestionTbls.ToList();



            IEnumerable<VoteViewModel> listvoteViewModels = (from objVote in objRatingDbEntities.VoteTbl
                                                             where objVote.AssignGroup == GroupID
                                                             select new VoteViewModel()
                                                             {
                                                                 VoteID = objVote.VoteID,
                                                                 VoteDescription = objVote.VoteDescription,
                                                                 VoteDescription2 = objVote.VoteDescription2,
                                                                 VoteDescription3 = objVote.VoteDescription3,
                                                                 Rating = objVote.Rating,
                                                                 Rating2 = objVote.Rating2,
                                                                 Rating3 = objVote.Rating3,
                                                                 AssignGroup = objVote.AssignGroup,
                                                                 CommentedOn = objVote.CommentedOn




                                                             }).ToList();

            ViewBag.AssignGroup = GroupID;

            return View(listvoteViewModels);

        }



        //public ActionResult ShowVote(int QuestionID)
        //{


        //    IEnumerable<VoteViewModel> listVoteViewModels = (from objVote in objRatingDbEntities.VoteTbls
        //                                                     where objVote.QuestionID == QuestionID
        //                                                     select new VoteViewModel()
        //                                                     {
        //                                                         QuestionID = objVote.QuestionID,
        //                                                         VoteDescription = objVote.VoteDescription,
        //                                                         VoteID = objVote.VoteID,
        //                                                         Rating = objVote.Rating,
        //                                                         CommentedOn = objVote.CommentedOn,



        //                                                     }).ToList();   //Burada FK ile bağladım.
        //    ViewBag.QuestionID = QuestionID; //Seçtiğim yorumu gösterir showvotecshtmlde hidden olarak kullanılıyor.
        //    return View(listVoteViewModels);
        //}

        //Burada where questionID sorgusunu Group veya Student ile değişitirirsen hangi öğreni hangi sorusunu yorum yapıldığını görür.
        //public ActionResult ShowVotee(int QuestionID)
        //{
        //    IEnumerable<VoteViewModel> listVoteViewModels = (from objVote in objRatingDbEntities.VoteTbls
        //                                                     where objVote.QuestionID == QuestionID
        //                                                     select new VoteViewModel()
        //                                                     {
        //                                                         QuestionID = objVote.QuestionID,
        //                                                         VoteDescription = objVote.VoteDescription,
        //                                                         VoteID = objVote.VoteID,
        //                                                         Rating = objVote.Rating,
        //                                                         CommentedOn = objVote.CommentedOn,



        //                                                     }).ToList();   //Burada FK ile bağladım.
        //    ViewBag.QuestionID = QuestionID; //Seçtiğim yorumu gösterir showvotecshtmlde hidden olarak kullanılıyor.
        //    return View(listVoteViewModels);
        //}


        [HttpPost]
        public ActionResult AddVote(int rating, int rating2, int rating3, string questionDescription, string questionDescription2, string questionDescription3, int assignGroup)
        {
            VoteTbl objVoteTbl = new VoteTbl();

            objVoteTbl.AssignGroup = assignGroup;
            objVoteTbl.Rating2 = rating2;
            objVoteTbl.Rating3 = rating3;
            objVoteTbl.VoteDescription3 = questionDescription3;
            objVoteTbl.VoteDescription2 = questionDescription2;
            objVoteTbl.VoteDescription = questionDescription;
            objVoteTbl.CommentedOn = DateTime.Now;
            objVoteTbl.Rating = rating;
            objRatingDbEntities.VoteTbl.Add(objVoteTbl);
            objRatingDbEntities.SaveChanges();

            //return PartialView("ShowVote", objVoteTbl);
            //return RedirectToAction("ShowVote", new { id = QuestionID});
            //return RedirectToAction("ShowVote",objVoteTbl.QuestionID);
            //return View("ShowVote", new { id = 1 });

            ////"~/Views/home/LoginRegister.cshtml"
            //return RedirectToAction("/Vote/ShowVote ? QuestionID=" + QuestionID);
            ////return RedirectToAction("/ShowVoteQuestion?ID=" + QuestionID);
            return RedirectToAction("SelectGroup");
        }
    }
}