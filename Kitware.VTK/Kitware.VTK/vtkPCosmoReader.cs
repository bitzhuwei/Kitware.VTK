using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPCosmoReader : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPCosmoReader";

		public new static readonly string MRClassNameKey;

		static vtkPCosmoReader()
		{
			vtkPCosmoReader.MRClassNameKey = "class vtkPCosmoReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPCosmoReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCosmoReader"));
		}

		public vtkPCosmoReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPCosmoReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPCosmoReader New()
		{
			vtkPCosmoReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCosmoReader.vtkPCosmoReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCosmoReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPCosmoReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPCosmoReader.vtkPCosmoReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPCosmoReader_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCosmoReader.vtkPCosmoReader_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCosmoReader_GetCosmoFormat_02(HandleRef pThis);

		public virtual int GetCosmoFormat()
		{
			return vtkPCosmoReader.vtkPCosmoReader_GetCosmoFormat_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPCosmoReader_GetFileName_03(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkPCosmoReader.vtkPCosmoReader_GetFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern float vtkPCosmoReader_GetOverlap_04(HandleRef pThis);

		public virtual float GetOverlap()
		{
			return vtkPCosmoReader.vtkPCosmoReader_GetOverlap_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern float vtkPCosmoReader_GetRL_05(HandleRef pThis);

		public virtual float GetRL()
		{
			return vtkPCosmoReader.vtkPCosmoReader_GetRL_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCosmoReader_GetReadMode_06(HandleRef pThis);

		public virtual int GetReadMode()
		{
			return vtkPCosmoReader.vtkPCosmoReader_GetReadMode_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCosmoReader_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPCosmoReader.vtkPCosmoReader_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCosmoReader_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPCosmoReader.vtkPCosmoReader_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPCosmoReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPCosmoReader NewInstance()
		{
			vtkPCosmoReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCosmoReader.vtkPCosmoReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCosmoReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPCosmoReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPCosmoReader SafeDownCast(vtkObjectBase o)
		{
			vtkPCosmoReader vtkPCosmoReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCosmoReader.vtkPCosmoReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPCosmoReader = (vtkPCosmoReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPCosmoReader.Register(null);
				}
			}
			return vtkPCosmoReader;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoReader_SetController_12(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPCosmoReader.vtkPCosmoReader_SetController_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoReader_SetCosmoFormat_13(HandleRef pThis, int _arg);

		public virtual void SetCosmoFormat(int _arg)
		{
			vtkPCosmoReader.vtkPCosmoReader_SetCosmoFormat_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoReader_SetFileName_14(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkPCosmoReader.vtkPCosmoReader_SetFileName_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoReader_SetOverlap_15(HandleRef pThis, float _arg);

		public virtual void SetOverlap(float _arg)
		{
			vtkPCosmoReader.vtkPCosmoReader_SetOverlap_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoReader_SetRL_16(HandleRef pThis, float _arg);

		public virtual void SetRL(float _arg)
		{
			vtkPCosmoReader.vtkPCosmoReader_SetRL_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCosmoReader_SetReadMode_17(HandleRef pThis, int _arg);

		public virtual void SetReadMode(int _arg)
		{
			vtkPCosmoReader.vtkPCosmoReader_SetReadMode_17(base.GetCppThis(), _arg);
		}
	}
}
