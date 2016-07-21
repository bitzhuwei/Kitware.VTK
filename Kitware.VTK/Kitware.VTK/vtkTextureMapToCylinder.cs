using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTextureMapToCylinder : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextureMapToCylinder";

		public new static readonly string MRClassNameKey;

		static vtkTextureMapToCylinder()
		{
			vtkTextureMapToCylinder.MRClassNameKey = "class vtkTextureMapToCylinder";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextureMapToCylinder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextureMapToCylinder"));
		}

		public vtkTextureMapToCylinder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToCylinder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextureMapToCylinder New()
		{
			vtkTextureMapToCylinder result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureMapToCylinder.vtkTextureMapToCylinder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureMapToCylinder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTextureMapToCylinder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTextureMapToCylinder.vtkTextureMapToCylinder_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToCylinder_AutomaticCylinderGenerationOff_01(HandleRef pThis);

		public virtual void AutomaticCylinderGenerationOff()
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_AutomaticCylinderGenerationOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToCylinder_AutomaticCylinderGenerationOn_02(HandleRef pThis);

		public virtual void AutomaticCylinderGenerationOn()
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_AutomaticCylinderGenerationOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextureMapToCylinder_GetAutomaticCylinderGeneration_03(HandleRef pThis);

		public virtual int GetAutomaticCylinderGeneration()
		{
			return vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetAutomaticCylinderGeneration_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToCylinder_GetPoint1_04(HandleRef pThis);

		public virtual double[] GetPoint1()
		{
			IntPtr intPtr = vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetPoint1_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToCylinder_GetPoint1_05(HandleRef pThis, IntPtr data);

		public virtual void GetPoint1(IntPtr data)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetPoint1_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToCylinder_GetPoint2_06(HandleRef pThis);

		public virtual double[] GetPoint2()
		{
			IntPtr intPtr = vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetPoint2_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToCylinder_GetPoint2_07(HandleRef pThis, IntPtr data);

		public virtual void GetPoint2(IntPtr data)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetPoint2_07(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextureMapToCylinder_GetPreventSeam_08(HandleRef pThis);

		public virtual int GetPreventSeam()
		{
			return vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetPreventSeam_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextureMapToCylinder_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTextureMapToCylinder.vtkTextureMapToCylinder_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextureMapToCylinder_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTextureMapToCylinder.vtkTextureMapToCylinder_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToCylinder_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTextureMapToCylinder NewInstance()
		{
			vtkTextureMapToCylinder result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureMapToCylinder.vtkTextureMapToCylinder_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureMapToCylinder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToCylinder_PreventSeamOff_13(HandleRef pThis);

		public virtual void PreventSeamOff()
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_PreventSeamOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToCylinder_PreventSeamOn_14(HandleRef pThis);

		public virtual void PreventSeamOn()
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_PreventSeamOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToCylinder_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextureMapToCylinder SafeDownCast(vtkObjectBase o)
		{
			vtkTextureMapToCylinder vtkTextureMapToCylinder = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureMapToCylinder.vtkTextureMapToCylinder_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextureMapToCylinder = (vtkTextureMapToCylinder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextureMapToCylinder.Register(null);
				}
			}
			return vtkTextureMapToCylinder;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToCylinder_SetAutomaticCylinderGeneration_16(HandleRef pThis, int _arg);

		public virtual void SetAutomaticCylinderGeneration(int _arg)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_SetAutomaticCylinderGeneration_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToCylinder_SetPoint1_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPoint1(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_SetPoint1_17(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToCylinder_SetPoint1_18(HandleRef pThis, IntPtr _arg);

		public virtual void SetPoint1(IntPtr _arg)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_SetPoint1_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToCylinder_SetPoint2_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPoint2(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_SetPoint2_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToCylinder_SetPoint2_20(HandleRef pThis, IntPtr _arg);

		public virtual void SetPoint2(IntPtr _arg)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_SetPoint2_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToCylinder_SetPreventSeam_21(HandleRef pThis, int _arg);

		public virtual void SetPreventSeam(int _arg)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_SetPreventSeam_21(base.GetCppThis(), _arg);
		}
	}
}
