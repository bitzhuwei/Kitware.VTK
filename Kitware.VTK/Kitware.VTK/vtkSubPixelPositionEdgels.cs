using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSubPixelPositionEdgels : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSubPixelPositionEdgels";

		public new static readonly string MRClassNameKey;

		static vtkSubPixelPositionEdgels()
		{
			vtkSubPixelPositionEdgels.MRClassNameKey = "class vtkSubPixelPositionEdgels";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSubPixelPositionEdgels.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubPixelPositionEdgels"));
		}

		public vtkSubPixelPositionEdgels(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSubPixelPositionEdgels_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSubPixelPositionEdgels New()
		{
			vtkSubPixelPositionEdgels result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubPixelPositionEdgels)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSubPixelPositionEdgels() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSubPixelPositionEdgels_GetGradMaps_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkStructuredPoints GetGradMaps()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_GetGradMaps_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSubPixelPositionEdgels_GetTargetFlag_02(HandleRef pThis);

		public virtual int GetTargetFlag()
		{
			return vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_GetTargetFlag_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSubPixelPositionEdgels_GetTargetValue_03(HandleRef pThis);

		public virtual double GetTargetValue()
		{
			return vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_GetTargetValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSubPixelPositionEdgels_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSubPixelPositionEdgels_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSubPixelPositionEdgels_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSubPixelPositionEdgels NewInstance()
		{
			vtkSubPixelPositionEdgels result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubPixelPositionEdgels)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSubPixelPositionEdgels_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSubPixelPositionEdgels SafeDownCast(vtkObjectBase o)
		{
			vtkSubPixelPositionEdgels vtkSubPixelPositionEdgels = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSubPixelPositionEdgels = (vtkSubPixelPositionEdgels)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSubPixelPositionEdgels.Register(null);
				}
			}
			return vtkSubPixelPositionEdgels;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSubPixelPositionEdgels_SetGradMaps_09(HandleRef pThis, HandleRef gm);

		public void SetGradMaps(vtkStructuredPoints gm)
		{
			vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_SetGradMaps_09(base.GetCppThis(), (gm == null) ? default(HandleRef) : gm.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSubPixelPositionEdgels_SetTargetFlag_10(HandleRef pThis, int _arg);

		public virtual void SetTargetFlag(int _arg)
		{
			vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_SetTargetFlag_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSubPixelPositionEdgels_SetTargetValue_11(HandleRef pThis, double _arg);

		public virtual void SetTargetValue(double _arg)
		{
			vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_SetTargetValue_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSubPixelPositionEdgels_TargetFlagOff_12(HandleRef pThis);

		public virtual void TargetFlagOff()
		{
			vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_TargetFlagOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSubPixelPositionEdgels_TargetFlagOn_13(HandleRef pThis);

		public virtual void TargetFlagOn()
		{
			vtkSubPixelPositionEdgels.vtkSubPixelPositionEdgels_TargetFlagOn_13(base.GetCppThis());
		}
	}
}
