using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAlgorithmOutput : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAlgorithmOutput";

		public new static readonly string MRClassNameKey;

		static vtkAlgorithmOutput()
		{
			vtkAlgorithmOutput.MRClassNameKey = "class vtkAlgorithmOutput";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAlgorithmOutput.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAlgorithmOutput"));
		}

		public vtkAlgorithmOutput(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithmOutput_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAlgorithmOutput New()
		{
			vtkAlgorithmOutput result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithmOutput.vtkAlgorithmOutput_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAlgorithmOutput() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAlgorithmOutput.vtkAlgorithmOutput_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithmOutput_GetIndex_01(HandleRef pThis);

		public int GetIndex()
		{
			return vtkAlgorithmOutput.vtkAlgorithmOutput_GetIndex_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithmOutput_GetProducer_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAlgorithm GetProducer()
		{
			vtkAlgorithm vtkAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithmOutput.vtkAlgorithmOutput_GetProducer_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithm = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithm.Register(null);
				}
			}
			return vtkAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithmOutput_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAlgorithmOutput.vtkAlgorithmOutput_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithmOutput_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAlgorithmOutput.vtkAlgorithmOutput_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithmOutput_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAlgorithmOutput NewInstance()
		{
			vtkAlgorithmOutput result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithmOutput.vtkAlgorithmOutput_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithmOutput_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAlgorithmOutput SafeDownCast(vtkObjectBase o)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithmOutput.vtkAlgorithmOutput_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithmOutput_SetIndex_08(HandleRef pThis, int index);

		public void SetIndex(int index)
		{
			vtkAlgorithmOutput.vtkAlgorithmOutput_SetIndex_08(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithmOutput_SetProducer_09(HandleRef pThis, HandleRef producer);

		public void SetProducer(vtkAlgorithm producer)
		{
			vtkAlgorithmOutput.vtkAlgorithmOutput_SetProducer_09(base.GetCppThis(), (producer == null) ? default(HandleRef) : producer.GetCppThis());
		}
	}
}
