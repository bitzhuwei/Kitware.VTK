using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkArrayDataAlgorithm : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayDataAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkArrayDataAlgorithm()
		{
			vtkArrayDataAlgorithm.MRClassNameKey = "class vtkArrayDataAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayDataAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayDataAlgorithm"));
		}

		public vtkArrayDataAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayDataAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayDataAlgorithm New()
		{
			vtkArrayDataAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkArrayDataAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayDataAlgorithm_GetOutput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkArrayData GetOutput()
		{
			vtkArrayData vtkArrayData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_GetOutput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayData = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayData.Register(null);
				}
			}
			return vtkArrayData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayDataAlgorithm_GetOutput_02(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkArrayData GetOutput(int index)
		{
			vtkArrayData vtkArrayData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_GetOutput_02(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayData = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayData.Register(null);
				}
			}
			return vtkArrayData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkArrayDataAlgorithm_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkArrayDataAlgorithm_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayDataAlgorithm_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkArrayDataAlgorithm NewInstance()
		{
			vtkArrayDataAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayDataAlgorithm_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayDataAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkArrayDataAlgorithm vtkArrayDataAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayDataAlgorithm = (vtkArrayDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayDataAlgorithm.Register(null);
				}
			}
			return vtkArrayDataAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkArrayDataAlgorithm_SetInput_08(HandleRef pThis, HandleRef obj);

		public void SetInput(vtkDataObject obj)
		{
			vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_SetInput_08(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkArrayDataAlgorithm_SetInput_09(HandleRef pThis, int index, HandleRef obj);

		public void SetInput(int index, vtkDataObject obj)
		{
			vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_SetInput_09(base.GetCppThis(), index, (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}
	}
}
