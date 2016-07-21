using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTextureMapToSphere : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextureMapToSphere";

		public new static readonly string MRClassNameKey;

		static vtkTextureMapToSphere()
		{
			vtkTextureMapToSphere.MRClassNameKey = "class vtkTextureMapToSphere";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextureMapToSphere.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextureMapToSphere"));
		}

		public vtkTextureMapToSphere(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToSphere_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextureMapToSphere New()
		{
			vtkTextureMapToSphere result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureMapToSphere.vtkTextureMapToSphere_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureMapToSphere)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTextureMapToSphere() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTextureMapToSphere.vtkTextureMapToSphere_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToSphere_AutomaticSphereGenerationOff_01(HandleRef pThis);

		public virtual void AutomaticSphereGenerationOff()
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_AutomaticSphereGenerationOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToSphere_AutomaticSphereGenerationOn_02(HandleRef pThis);

		public virtual void AutomaticSphereGenerationOn()
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_AutomaticSphereGenerationOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextureMapToSphere_GetAutomaticSphereGeneration_03(HandleRef pThis);

		public virtual int GetAutomaticSphereGeneration()
		{
			return vtkTextureMapToSphere.vtkTextureMapToSphere_GetAutomaticSphereGeneration_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToSphere_GetCenter_04(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkTextureMapToSphere.vtkTextureMapToSphere_GetCenter_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToSphere_GetCenter_05(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_GetCenter_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextureMapToSphere_GetPreventSeam_06(HandleRef pThis);

		public virtual int GetPreventSeam()
		{
			return vtkTextureMapToSphere.vtkTextureMapToSphere_GetPreventSeam_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextureMapToSphere_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTextureMapToSphere.vtkTextureMapToSphere_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTextureMapToSphere_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTextureMapToSphere.vtkTextureMapToSphere_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToSphere_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTextureMapToSphere NewInstance()
		{
			vtkTextureMapToSphere result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureMapToSphere.vtkTextureMapToSphere_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureMapToSphere)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToSphere_PreventSeamOff_11(HandleRef pThis);

		public virtual void PreventSeamOff()
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_PreventSeamOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToSphere_PreventSeamOn_12(HandleRef pThis);

		public virtual void PreventSeamOn()
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_PreventSeamOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureMapToSphere_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextureMapToSphere SafeDownCast(vtkObjectBase o)
		{
			vtkTextureMapToSphere vtkTextureMapToSphere = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureMapToSphere.vtkTextureMapToSphere_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextureMapToSphere = (vtkTextureMapToSphere)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextureMapToSphere.Register(null);
				}
			}
			return vtkTextureMapToSphere;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToSphere_SetAutomaticSphereGeneration_14(HandleRef pThis, int _arg);

		public virtual void SetAutomaticSphereGeneration(int _arg)
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_SetAutomaticSphereGeneration_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToSphere_SetCenter_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_SetCenter_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToSphere_SetCenter_16(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_SetCenter_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTextureMapToSphere_SetPreventSeam_17(HandleRef pThis, int _arg);

		public virtual void SetPreventSeam(int _arg)
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_SetPreventSeam_17(base.GetCppThis(), _arg);
		}
	}
}
