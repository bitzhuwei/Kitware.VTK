using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyDataAlgorithm : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataAlgorithm()
		{
			vtkPolyDataAlgorithm.MRClassNameKey = "class vtkPolyDataAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataAlgorithm"));
		}

		public vtkPolyDataAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataAlgorithm New()
		{
			vtkPolyDataAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyDataAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyDataAlgorithm_AddInput_01(HandleRef pThis, HandleRef arg0);

		public void AddInput(vtkDataObject arg0)
		{
			vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_AddInput_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyDataAlgorithm_AddInput_02(HandleRef pThis, int arg0, HandleRef arg1);

		public void AddInput(int arg0, vtkDataObject arg1)
		{
			vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_AddInput_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataAlgorithm_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_GetInput_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataAlgorithm_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataAlgorithm_GetOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_GetOutput_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataAlgorithm_GetOutput_06(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetOutput(int arg0)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_GetOutput_06(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataAlgorithm_GetPolyDataInput_07(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetPolyDataInput(int port)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_GetPolyDataInput_07(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyDataAlgorithm_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyDataAlgorithm_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataAlgorithm_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataAlgorithm NewInstance()
		{
			vtkPolyDataAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataAlgorithm_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyDataAlgorithm_SetInput_13(HandleRef pThis, HandleRef arg0);

		public void SetInput(vtkDataObject arg0)
		{
			vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_SetInput_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyDataAlgorithm_SetInput_14(HandleRef pThis, int arg0, HandleRef arg1);

		public void SetInput(int arg0, vtkDataObject arg1)
		{
			vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_SetInput_14(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyDataAlgorithm_SetOutput_15(HandleRef pThis, HandleRef d);

		public virtual void SetOutput(vtkDataObject d)
		{
			vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_SetOutput_15(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}
	}
}
