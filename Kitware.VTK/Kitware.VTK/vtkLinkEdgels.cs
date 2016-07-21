using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLinkEdgels : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinkEdgels";

		public new static readonly string MRClassNameKey;

		static vtkLinkEdgels()
		{
			vtkLinkEdgels.MRClassNameKey = "class vtkLinkEdgels";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinkEdgels.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinkEdgels"));
		}

		public vtkLinkEdgels(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLinkEdgels_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLinkEdgels New()
		{
			vtkLinkEdgels result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinkEdgels.vtkLinkEdgels_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinkEdgels)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLinkEdgels() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLinkEdgels.vtkLinkEdgels_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkLinkEdgels_GetGradientThreshold_01(HandleRef pThis);

		public virtual double GetGradientThreshold()
		{
			return vtkLinkEdgels.vtkLinkEdgels_GetGradientThreshold_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkLinkEdgels_GetLinkThreshold_02(HandleRef pThis);

		public virtual double GetLinkThreshold()
		{
			return vtkLinkEdgels.vtkLinkEdgels_GetLinkThreshold_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkLinkEdgels_GetPhiThreshold_03(HandleRef pThis);

		public virtual double GetPhiThreshold()
		{
			return vtkLinkEdgels.vtkLinkEdgels_GetPhiThreshold_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLinkEdgels_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLinkEdgels.vtkLinkEdgels_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLinkEdgels_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLinkEdgels.vtkLinkEdgels_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLinkEdgels_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLinkEdgels NewInstance()
		{
			vtkLinkEdgels result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinkEdgels.vtkLinkEdgels_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinkEdgels)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLinkEdgels_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLinkEdgels SafeDownCast(vtkObjectBase o)
		{
			vtkLinkEdgels vtkLinkEdgels = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinkEdgels.vtkLinkEdgels_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinkEdgels = (vtkLinkEdgels)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinkEdgels.Register(null);
				}
			}
			return vtkLinkEdgels;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinkEdgels_SetGradientThreshold_09(HandleRef pThis, double _arg);

		public virtual void SetGradientThreshold(double _arg)
		{
			vtkLinkEdgels.vtkLinkEdgels_SetGradientThreshold_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinkEdgels_SetLinkThreshold_10(HandleRef pThis, double _arg);

		public virtual void SetLinkThreshold(double _arg)
		{
			vtkLinkEdgels.vtkLinkEdgels_SetLinkThreshold_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLinkEdgels_SetPhiThreshold_11(HandleRef pThis, double _arg);

		public virtual void SetPhiThreshold(double _arg)
		{
			vtkLinkEdgels.vtkLinkEdgels_SetPhiThreshold_11(base.GetCppThis(), _arg);
		}
	}
}
