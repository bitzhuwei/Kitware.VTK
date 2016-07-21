using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAppendPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAppendPolyData";

		public new static readonly string MRClassNameKey;

		static vtkAppendPolyData()
		{
			vtkAppendPolyData.MRClassNameKey = "class vtkAppendPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAppendPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendPolyData"));
		}

		public vtkAppendPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAppendPolyData New()
		{
			vtkAppendPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendPolyData.vtkAppendPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAppendPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAppendPolyData.vtkAppendPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendPolyData_AddInput_01(HandleRef pThis, HandleRef arg0);

		public void AddInput(vtkPolyData arg0)
		{
			vtkAppendPolyData.vtkAppendPolyData_AddInput_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendPolyData_GetInput_02(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyData GetInput(int idx)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendPolyData.vtkAppendPolyData_GetInput_02(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendPolyData_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendPolyData.vtkAppendPolyData_GetInput_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAppendPolyData_GetParallelStreaming_04(HandleRef pThis);

		public virtual int GetParallelStreaming()
		{
			return vtkAppendPolyData.vtkAppendPolyData_GetParallelStreaming_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAppendPolyData_GetUserManagedInputs_05(HandleRef pThis);

		public virtual int GetUserManagedInputs()
		{
			return vtkAppendPolyData.vtkAppendPolyData_GetUserManagedInputs_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAppendPolyData_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAppendPolyData.vtkAppendPolyData_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAppendPolyData_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAppendPolyData.vtkAppendPolyData_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendPolyData_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAppendPolyData NewInstance()
		{
			vtkAppendPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendPolyData.vtkAppendPolyData_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendPolyData_ParallelStreamingOff_10(HandleRef pThis);

		public virtual void ParallelStreamingOff()
		{
			vtkAppendPolyData.vtkAppendPolyData_ParallelStreamingOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendPolyData_ParallelStreamingOn_11(HandleRef pThis);

		public virtual void ParallelStreamingOn()
		{
			vtkAppendPolyData.vtkAppendPolyData_ParallelStreamingOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendPolyData_RemoveInput_12(HandleRef pThis, HandleRef arg0);

		public void RemoveInput(vtkPolyData arg0)
		{
			vtkAppendPolyData.vtkAppendPolyData_RemoveInput_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendPolyData_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAppendPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkAppendPolyData vtkAppendPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendPolyData.vtkAppendPolyData_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAppendPolyData = (vtkAppendPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAppendPolyData.Register(null);
				}
			}
			return vtkAppendPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendPolyData_SetInputByNumber_14(HandleRef pThis, int num, HandleRef input);

		public void SetInputByNumber(int num, vtkPolyData input)
		{
			vtkAppendPolyData.vtkAppendPolyData_SetInputByNumber_14(base.GetCppThis(), num, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendPolyData_SetNumberOfInputs_15(HandleRef pThis, int num);

		public void SetNumberOfInputs(int num)
		{
			vtkAppendPolyData.vtkAppendPolyData_SetNumberOfInputs_15(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendPolyData_SetParallelStreaming_16(HandleRef pThis, int _arg);

		public virtual void SetParallelStreaming(int _arg)
		{
			vtkAppendPolyData.vtkAppendPolyData_SetParallelStreaming_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendPolyData_SetUserManagedInputs_17(HandleRef pThis, int _arg);

		public virtual void SetUserManagedInputs(int _arg)
		{
			vtkAppendPolyData.vtkAppendPolyData_SetUserManagedInputs_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendPolyData_UserManagedInputsOff_18(HandleRef pThis);

		public virtual void UserManagedInputsOff()
		{
			vtkAppendPolyData.vtkAppendPolyData_UserManagedInputsOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendPolyData_UserManagedInputsOn_19(HandleRef pThis);

		public virtual void UserManagedInputsOn()
		{
			vtkAppendPolyData.vtkAppendPolyData_UserManagedInputsOn_19(base.GetCppThis());
		}
	}
}
