﻿using CoreBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        List<Comment> GetList(int id);
        List<Comment> GetCommentWithBlog();
    }
}