using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTensor : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTensor";

		public new static readonly string MRClassNameKey;

		static vtkTensor()
		{
			vtkTensor.MRClassNameKey = "class vtkTensor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTensor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensor"));
		}

		public vtkTensor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTensor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTensor New()
		{
			vtkTensor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTensor.vtkTensor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTensor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTensor.vtkTensor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTensor_AddComponent_01(HandleRef pThis, int i, int j, double v);

		public void AddComponent(int i, int j, double v)
		{
			vtkTensor.vtkTensor_AddComponent_01(base.GetCppThis(), i, j, v);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTensor_DeepCopy_02(HandleRef pThis, HandleRef t);

		public void DeepCopy(vtkTensor t)
		{
			vtkTensor.vtkTensor_DeepCopy_02(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTensor_GetColumn_03(HandleRef pThis, int j);

		public IntPtr GetColumn(int j)
		{
			return vtkTensor.vtkTensor_GetColumn_03(base.GetCppThis(), j);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkTensor_GetComponent_04(HandleRef pThis, int i, int j);

		public double GetComponent(int i, int j)
		{
			return vtkTensor.vtkTensor_GetComponent_04(base.GetCppThis(), i, j);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTensor_Initialize_05(HandleRef pThis);

		public void Initialize()
		{
			vtkTensor.vtkTensor_Initialize_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTensor_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTensor.vtkTensor_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTensor_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTensor.vtkTensor_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTensor_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTensor NewInstance()
		{
			vtkTensor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTensor.vtkTensor_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTensor_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTensor SafeDownCast(vtkObjectBase o)
		{
			vtkTensor vtkTensor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTensor.vtkTensor_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTensor = (vtkTensor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTensor.Register(null);
				}
			}
			return vtkTensor;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTensor_SetComponent_11(HandleRef pThis, int i, int j, double v);

		public void SetComponent(int i, int j, double v)
		{
			vtkTensor.vtkTensor_SetComponent_11(base.GetCppThis(), i, j, v);
		}
	}
}
