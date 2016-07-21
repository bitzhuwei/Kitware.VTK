using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProcessObject : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProcessObject";

		public new static readonly string MRClassNameKey;

		static vtkProcessObject()
		{
			vtkProcessObject.MRClassNameKey = "class vtkProcessObject";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProcessObject.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProcessObject"));
		}

		public vtkProcessObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkProcessObject_AddInputConnection_01(HandleRef pThis, int port, HandleRef input);

		public override void AddInputConnection(int port, vtkAlgorithmOutput input)
		{
			vtkProcessObject.vtkProcessObject_AddInputConnection_01(base.GetCppThis(), port, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkProcessObject_AddInputConnection_02(HandleRef pThis, HandleRef input);

		public override void AddInputConnection(vtkAlgorithmOutput input)
		{
			vtkProcessObject.vtkProcessObject_AddInputConnection_02(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkProcessObject_GetNumberOfInputs_03(HandleRef pThis);

		public int GetNumberOfInputs()
		{
			return vtkProcessObject.vtkProcessObject_GetNumberOfInputs_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkProcessObject_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProcessObject.vtkProcessObject_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkProcessObject_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProcessObject.vtkProcessObject_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkProcessObject_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProcessObject NewInstance()
		{
			vtkProcessObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcessObject.vtkProcessObject_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcessObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkProcessObject_RemoveAllInputs_07(HandleRef pThis);

		public new void RemoveAllInputs()
		{
			vtkProcessObject.vtkProcessObject_RemoveAllInputs_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkProcessObject_RemoveInputConnection_08(HandleRef pThis, int port, HandleRef input);

		public override void RemoveInputConnection(int port, vtkAlgorithmOutput input)
		{
			vtkProcessObject.vtkProcessObject_RemoveInputConnection_08(base.GetCppThis(), port, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkProcessObject_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProcessObject SafeDownCast(vtkObjectBase o)
		{
			vtkProcessObject vtkProcessObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcessObject.vtkProcessObject_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProcessObject = (vtkProcessObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProcessObject.Register(null);
				}
			}
			return vtkProcessObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkProcessObject_SetInputConnection_10(HandleRef pThis, HandleRef input);

		public override void SetInputConnection(vtkAlgorithmOutput input)
		{
			vtkProcessObject.vtkProcessObject_SetInputConnection_10(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkProcessObject_SetInputConnection_11(HandleRef pThis, int port, HandleRef input);

		public override void SetInputConnection(int port, vtkAlgorithmOutput input)
		{
			vtkProcessObject.vtkProcessObject_SetInputConnection_11(base.GetCppThis(), port, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkProcessObject_SetNthInputConnection_12(HandleRef pThis, int port, int index, HandleRef input);

		public virtual void SetNthInputConnection(int port, int index, vtkAlgorithmOutput input)
		{
			vtkProcessObject.vtkProcessObject_SetNthInputConnection_12(base.GetCppThis(), port, index, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkProcessObject_SetNumberOfInputConnections_13(HandleRef pThis, int port, int n);

		public virtual void SetNumberOfInputConnections(int port, int n)
		{
			vtkProcessObject.vtkProcessObject_SetNumberOfInputConnections_13(base.GetCppThis(), port, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkProcessObject_SqueezeInputArray_14(HandleRef pThis);

		public void SqueezeInputArray()
		{
			vtkProcessObject.vtkProcessObject_SqueezeInputArray_14(base.GetCppThis());
		}
	}
}
