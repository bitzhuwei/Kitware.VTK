using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTrivialProducer : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTrivialProducer";

		public new static readonly string MRClassNameKey;

		static vtkTrivialProducer()
		{
			vtkTrivialProducer.MRClassNameKey = "class vtkTrivialProducer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTrivialProducer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTrivialProducer"));
		}

		public vtkTrivialProducer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTrivialProducer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTrivialProducer New()
		{
			vtkTrivialProducer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTrivialProducer.vtkTrivialProducer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTrivialProducer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTrivialProducer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTrivialProducer.vtkTrivialProducer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkTrivialProducer_GetMTime_01(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkTrivialProducer.vtkTrivialProducer_GetMTime_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTrivialProducer_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTrivialProducer.vtkTrivialProducer_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTrivialProducer_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTrivialProducer.vtkTrivialProducer_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTrivialProducer_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTrivialProducer NewInstance()
		{
			vtkTrivialProducer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTrivialProducer.vtkTrivialProducer_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTrivialProducer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTrivialProducer_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTrivialProducer SafeDownCast(vtkObjectBase o)
		{
			vtkTrivialProducer vtkTrivialProducer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTrivialProducer.vtkTrivialProducer_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTrivialProducer = (vtkTrivialProducer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTrivialProducer.Register(null);
				}
			}
			return vtkTrivialProducer;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTrivialProducer_SetOutput_07(HandleRef pThis, HandleRef output);

		public virtual void SetOutput(vtkDataObject output)
		{
			vtkTrivialProducer.vtkTrivialProducer_SetOutput_07(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}
	}
}
