using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVertexDegree : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVertexDegree";

		public new static readonly string MRClassNameKey;

		static vtkVertexDegree()
		{
			vtkVertexDegree.MRClassNameKey = "class vtkVertexDegree";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVertexDegree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVertexDegree"));
		}

		public vtkVertexDegree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkVertexDegree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVertexDegree New()
		{
			vtkVertexDegree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVertexDegree.vtkVertexDegree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertexDegree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVertexDegree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVertexDegree.vtkVertexDegree_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkVertexDegree_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVertexDegree.vtkVertexDegree_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkVertexDegree_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVertexDegree.vtkVertexDegree_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkVertexDegree_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVertexDegree NewInstance()
		{
			vtkVertexDegree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVertexDegree.vtkVertexDegree_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertexDegree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkVertexDegree_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVertexDegree SafeDownCast(vtkObjectBase o)
		{
			vtkVertexDegree vtkVertexDegree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVertexDegree.vtkVertexDegree_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVertexDegree = (vtkVertexDegree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVertexDegree.Register(null);
				}
			}
			return vtkVertexDegree;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkVertexDegree_SetOutputArrayName_06(HandleRef pThis, string _arg);

		public virtual void SetOutputArrayName(string _arg)
		{
			vtkVertexDegree.vtkVertexDegree_SetOutputArrayName_06(base.GetCppThis(), _arg);
		}
	}
}
