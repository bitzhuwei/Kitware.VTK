using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractSelectedFrustum : vtkExtractSelectionBase
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedFrustum";

		public new static readonly string MRClassNameKey;

		static vtkExtractSelectedFrustum()
		{
			vtkExtractSelectedFrustum.MRClassNameKey = "class vtkExtractSelectedFrustum";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedFrustum.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedFrustum"));
		}

		public vtkExtractSelectedFrustum(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedFrustum_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedFrustum New()
		{
			vtkExtractSelectedFrustum result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedFrustum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractSelectedFrustum() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedFrustum_CreateFrustum_01(HandleRef pThis, IntPtr vertices);

		public void CreateFrustum(IntPtr vertices)
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_CreateFrustum_01(base.GetCppThis(), vertices);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedFrustum_GetClipPoints_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetClipPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetClipPoints_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedFrustum_GetContainingCells_03(HandleRef pThis);

		public virtual int GetContainingCells()
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetContainingCells_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedFrustum_GetFieldType_04(HandleRef pThis);

		public virtual int GetFieldType()
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetFieldType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedFrustum_GetFrustum_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPlanes GetFrustum()
		{
			vtkPlanes vtkPlanes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetFrustum_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlanes = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlanes.Register(null);
				}
			}
			return vtkPlanes;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedFrustum_GetInsideOut_06(HandleRef pThis);

		public virtual int GetInsideOut()
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetInsideOut_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkExtractSelectedFrustum_GetMTime_07(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetMTime_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedFrustum_GetShowBounds_08(HandleRef pThis);

		public virtual int GetShowBounds()
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetShowBounds_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedFrustum_InsideOutOff_09(HandleRef pThis);

		public virtual void InsideOutOff()
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_InsideOutOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedFrustum_InsideOutOn_10(HandleRef pThis);

		public virtual void InsideOutOn()
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_InsideOutOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedFrustum_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedFrustum_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedFrustum_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractSelectedFrustum NewInstance()
		{
			vtkExtractSelectedFrustum result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedFrustum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedFrustum_OverallBoundsTest_15(HandleRef pThis, IntPtr bounds);

		public int OverallBoundsTest(IntPtr bounds)
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_OverallBoundsTest_15(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedFrustum_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedFrustum SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedFrustum vtkExtractSelectedFrustum = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedFrustum = (vtkExtractSelectedFrustum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedFrustum.Register(null);
				}
			}
			return vtkExtractSelectedFrustum;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedFrustum_SetContainingCells_17(HandleRef pThis, int _arg);

		public virtual void SetContainingCells(int _arg)
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_SetContainingCells_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedFrustum_SetFieldType_18(HandleRef pThis, int _arg);

		public virtual void SetFieldType(int _arg)
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_SetFieldType_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedFrustum_SetFrustum_19(HandleRef pThis, HandleRef arg0);

		public virtual void SetFrustum(vtkPlanes arg0)
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_SetFrustum_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedFrustum_SetInsideOut_20(HandleRef pThis, int _arg);

		public virtual void SetInsideOut(int _arg)
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_SetInsideOut_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedFrustum_SetShowBounds_21(HandleRef pThis, int _arg);

		public virtual void SetShowBounds(int _arg)
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_SetShowBounds_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedFrustum_ShowBoundsOff_22(HandleRef pThis);

		public virtual void ShowBoundsOff()
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_ShowBoundsOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedFrustum_ShowBoundsOn_23(HandleRef pThis);

		public virtual void ShowBoundsOn()
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_ShowBoundsOn_23(base.GetCppThis());
		}
	}
}
