using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAxes : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxes";

		public new static readonly string MRClassNameKey;

		static vtkAxes()
		{
			vtkAxes.MRClassNameKey = "class vtkAxes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxes"));
		}

		public vtkAxes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAxes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxes New()
		{
			vtkAxes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxes.vtkAxes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAxes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAxes.vtkAxes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAxes_ComputeNormalsOff_01(HandleRef pThis);

		public virtual void ComputeNormalsOff()
		{
			vtkAxes.vtkAxes_ComputeNormalsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAxes_ComputeNormalsOn_02(HandleRef pThis);

		public virtual void ComputeNormalsOn()
		{
			vtkAxes.vtkAxes_ComputeNormalsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAxes_GetComputeNormals_03(HandleRef pThis);

		public virtual int GetComputeNormals()
		{
			return vtkAxes.vtkAxes_GetComputeNormals_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAxes_GetOrigin_04(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkAxes.vtkAxes_GetOrigin_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAxes_GetOrigin_05(HandleRef pThis, IntPtr data);

		public virtual void GetOrigin(IntPtr data)
		{
			vtkAxes.vtkAxes_GetOrigin_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkAxes_GetScaleFactor_06(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkAxes.vtkAxes_GetScaleFactor_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAxes_GetSymmetric_07(HandleRef pThis);

		public virtual int GetSymmetric()
		{
			return vtkAxes.vtkAxes_GetSymmetric_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAxes_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAxes.vtkAxes_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAxes_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAxes.vtkAxes_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAxes_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAxes NewInstance()
		{
			vtkAxes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxes.vtkAxes_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAxes_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxes SafeDownCast(vtkObjectBase o)
		{
			vtkAxes vtkAxes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxes.vtkAxes_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxes = (vtkAxes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxes.Register(null);
				}
			}
			return vtkAxes;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAxes_SetComputeNormals_13(HandleRef pThis, int _arg);

		public virtual void SetComputeNormals(int _arg)
		{
			vtkAxes.vtkAxes_SetComputeNormals_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAxes_SetOrigin_14(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkAxes.vtkAxes_SetOrigin_14(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAxes_SetOrigin_15(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkAxes.vtkAxes_SetOrigin_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAxes_SetScaleFactor_16(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkAxes.vtkAxes_SetScaleFactor_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAxes_SetSymmetric_17(HandleRef pThis, int _arg);

		public virtual void SetSymmetric(int _arg)
		{
			vtkAxes.vtkAxes_SetSymmetric_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAxes_SymmetricOff_18(HandleRef pThis);

		public virtual void SymmetricOff()
		{
			vtkAxes.vtkAxes_SymmetricOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAxes_SymmetricOn_19(HandleRef pThis);

		public virtual void SymmetricOn()
		{
			vtkAxes.vtkAxes_SymmetricOn_19(base.GetCppThis());
		}
	}
}
