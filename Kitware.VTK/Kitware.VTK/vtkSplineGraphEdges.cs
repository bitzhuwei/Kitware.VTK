using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSplineGraphEdges : vtkGraphAlgorithm
	{
		public enum BSPLINE_WrapperEnum
		{
			BSPLINE,
			CUSTOM
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSplineGraphEdges";

		public new static readonly string MRClassNameKey;

		static vtkSplineGraphEdges()
		{
			vtkSplineGraphEdges.MRClassNameKey = "class vtkSplineGraphEdges";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplineGraphEdges.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineGraphEdges"));
		}

		public vtkSplineGraphEdges(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineGraphEdges_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplineGraphEdges New()
		{
			vtkSplineGraphEdges result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineGraphEdges.vtkSplineGraphEdges_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineGraphEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSplineGraphEdges() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSplineGraphEdges.vtkSplineGraphEdges_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkSplineGraphEdges_GetNumberOfSubdivisions_01(HandleRef pThis);

		public virtual long GetNumberOfSubdivisions()
		{
			return vtkSplineGraphEdges.vtkSplineGraphEdges_GetNumberOfSubdivisions_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineGraphEdges_GetSpline_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSpline GetSpline()
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineGraphEdges.vtkSplineGraphEdges_GetSpline_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpline = (vtkSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpline.Register(null);
				}
			}
			return vtkSpline;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSplineGraphEdges_GetSplineType_03(HandleRef pThis);

		public virtual int GetSplineType()
		{
			return vtkSplineGraphEdges.vtkSplineGraphEdges_GetSplineType_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSplineGraphEdges_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSplineGraphEdges.vtkSplineGraphEdges_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSplineGraphEdges_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSplineGraphEdges.vtkSplineGraphEdges_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineGraphEdges_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSplineGraphEdges NewInstance()
		{
			vtkSplineGraphEdges result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineGraphEdges.vtkSplineGraphEdges_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineGraphEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSplineGraphEdges_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplineGraphEdges SafeDownCast(vtkObjectBase o)
		{
			vtkSplineGraphEdges vtkSplineGraphEdges = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplineGraphEdges.vtkSplineGraphEdges_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplineGraphEdges = (vtkSplineGraphEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplineGraphEdges.Register(null);
				}
			}
			return vtkSplineGraphEdges;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSplineGraphEdges_SetNumberOfSubdivisions_09(HandleRef pThis, long _arg);

		public virtual void SetNumberOfSubdivisions(long _arg)
		{
			vtkSplineGraphEdges.vtkSplineGraphEdges_SetNumberOfSubdivisions_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSplineGraphEdges_SetSpline_10(HandleRef pThis, HandleRef s);

		public virtual void SetSpline(vtkSpline s)
		{
			vtkSplineGraphEdges.vtkSplineGraphEdges_SetSpline_10(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSplineGraphEdges_SetSplineType_11(HandleRef pThis, int _arg);

		public virtual void SetSplineType(int _arg)
		{
			vtkSplineGraphEdges.vtkSplineGraphEdges_SetSplineType_11(base.GetCppThis(), _arg);
		}
	}
}
