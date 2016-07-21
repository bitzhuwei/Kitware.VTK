using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCellDerivatives : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellDerivatives";

		public new static readonly string MRClassNameKey;

		static vtkCellDerivatives()
		{
			vtkCellDerivatives.MRClassNameKey = "class vtkCellDerivatives";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellDerivatives.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellDerivatives"));
		}

		public vtkCellDerivatives(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellDerivatives_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellDerivatives New()
		{
			vtkCellDerivatives result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellDerivatives.vtkCellDerivatives_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellDerivatives)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCellDerivatives() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCellDerivatives.vtkCellDerivatives_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellDerivatives_GetTensorMode_01(HandleRef pThis);

		public virtual int GetTensorMode()
		{
			return vtkCellDerivatives.vtkCellDerivatives_GetTensorMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellDerivatives_GetTensorModeAsString_02(HandleRef pThis);

		public string GetTensorModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkCellDerivatives.vtkCellDerivatives_GetTensorModeAsString_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellDerivatives_GetVectorMode_03(HandleRef pThis);

		public virtual int GetVectorMode()
		{
			return vtkCellDerivatives.vtkCellDerivatives_GetVectorMode_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellDerivatives_GetVectorModeAsString_04(HandleRef pThis);

		public string GetVectorModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkCellDerivatives.vtkCellDerivatives_GetVectorModeAsString_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellDerivatives_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCellDerivatives.vtkCellDerivatives_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellDerivatives_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCellDerivatives.vtkCellDerivatives_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellDerivatives_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCellDerivatives NewInstance()
		{
			vtkCellDerivatives result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellDerivatives.vtkCellDerivatives_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellDerivatives)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellDerivatives_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellDerivatives SafeDownCast(vtkObjectBase o)
		{
			vtkCellDerivatives vtkCellDerivatives = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellDerivatives.vtkCellDerivatives_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellDerivatives = (vtkCellDerivatives)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellDerivatives.Register(null);
				}
			}
			return vtkCellDerivatives;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellDerivatives_SetTensorMode_10(HandleRef pThis, int _arg);

		public virtual void SetTensorMode(int _arg)
		{
			vtkCellDerivatives.vtkCellDerivatives_SetTensorMode_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellDerivatives_SetTensorModeToComputeGradient_11(HandleRef pThis);

		public void SetTensorModeToComputeGradient()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetTensorModeToComputeGradient_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellDerivatives_SetTensorModeToComputeStrain_12(HandleRef pThis);

		public void SetTensorModeToComputeStrain()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetTensorModeToComputeStrain_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellDerivatives_SetTensorModeToPassTensors_13(HandleRef pThis);

		public void SetTensorModeToPassTensors()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetTensorModeToPassTensors_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellDerivatives_SetVectorMode_14(HandleRef pThis, int _arg);

		public virtual void SetVectorMode(int _arg)
		{
			vtkCellDerivatives.vtkCellDerivatives_SetVectorMode_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellDerivatives_SetVectorModeToComputeGradient_15(HandleRef pThis);

		public void SetVectorModeToComputeGradient()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetVectorModeToComputeGradient_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellDerivatives_SetVectorModeToComputeVorticity_16(HandleRef pThis);

		public void SetVectorModeToComputeVorticity()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetVectorModeToComputeVorticity_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellDerivatives_SetVectorModeToPassVectors_17(HandleRef pThis);

		public void SetVectorModeToPassVectors()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetVectorModeToPassVectors_17(base.GetCppThis());
		}
	}
}
